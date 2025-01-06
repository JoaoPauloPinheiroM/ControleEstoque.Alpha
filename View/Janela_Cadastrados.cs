
using Microsoft.Data.SqlClient;
using System.Configuration;
using Control;

namespace View
{
    public partial class Janela_Cadastrados : Form
    {

        Servico servico;
        string connectionString = ConfigurationManager.ConnectionStrings ["CS_ADO_NET"].ConnectionString;

        public Janela_Cadastrados ()
        {
            InitializeComponent();
            servico = new Servico(new SqlConnection(connectionString));
            AtualizarGrid();
        }

        // REMOVE CADASTROS
        private void btt_Remover_Cadastros_Click ( object sender , EventArgs e )
        {
            try
            {
                string codigo = txt_Codigo_Cadastros.Text;
                servico.RemoverCadastro(codigo);
                MessageBox.Show("Cadastro removido.");
                LimparCampos();
                AtualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao tentar remover cadastro {ex.Message}");
                AtualizarGrid();
            }
        }

        private void LimparCampos ()
        {
            txt_Codigo_Cadastros.Text = "";
            txt_Descricao_Cadastros.Text = "";
            
        }

        private void AtualizarGrid ()
        {
            string? codigo = txt_Codigo_Cadastros.Text;
            string descricao = txt_Descricao_Cadastros.Text;
            dgv_Cadastros.DataSource = null;

            // CASO OS CAMPOS CODIGO E DESCRICAO DOS FILTROS ESTEJAM VAZIOS, ELE CHAMA O METODO OBTERCADASTROS
            if (string.IsNullOrEmpty(codigo) && string.IsNullOrEmpty(descricao))
            {


            dgv_Cadastros.DataSource = servico.ObterCadastros();
        }
            else
            {
                var produtosFiltrados = servico.FiltrarCadastros(codigo , descricao);
                if (produtosFiltrados.Count == 0)
                {
                    MessageBox.Show("Nenhum produto encontrado." , "Aviso" , MessageBoxButtons.OK , MessageBoxIcon.Warning);
                }
                dgv_Cadastros.DataSource = produtosFiltrados;
            }
        }

        private void btt_Filtrar_Cadastrar_Click ( object sender , EventArgs e )
        {

            AtualizarGrid(); // POR ENQUANTO BUSCAR O METODO ATUALIZAR GRID

        }
    }
}
