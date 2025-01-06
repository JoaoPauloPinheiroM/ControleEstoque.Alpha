using Model;
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

        private void btt_Remover_Cadastros_Click ( object sender , EventArgs e )
        {
            try
            {
                var produto = new Produto
                {
                    Codigo = txt_Codigo_Cadastros.Text
                };
                servico.RemoverCadastro(produto);
                MessageBox.Show("Cadastro removido.");
                LimparCampos();
                AtualizarGrid ();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao tentar remover cadastro {ex.Message}");
                AtualizarGrid () ;
            }
        }

        private void LimparCampos ()
        {
            txt_Codigo_Cadastros.Text = "";
            txt_Descricao_Cadastros.Text = "";
            
        }

        private void AtualizarGrid ()
        {
            dgv_Cadastros.DataSource = null;
            dgv_Cadastros.DataSource = servico.ObterCadastros();
        }
    }
}
