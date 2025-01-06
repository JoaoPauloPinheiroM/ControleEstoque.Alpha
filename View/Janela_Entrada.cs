using Model;
using Control;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Text.Json;

namespace View
{
    public partial class Janela_Entrada : Form
    {
        Servico servico;
        string connectionString = ConfigurationManager.ConnectionStrings ["CS_ADO_NET"].ConnectionString;

        private Janela_Estoque janelaEstoque;
        public Janela_Entrada (Janela_Estoque janelaEstoque)
        {
            InitializeComponent();
            servico = new Servico(new SqlConnection(connectionString));
            this.janelaEstoque = janelaEstoque;
        }

        private void btt_Entrada_Click ( object sender , EventArgs e )
        {
           
            try
            {
                var produto = new Produto
                {
                    Codigo = txt_Codigo_Entrada.Text ,
                    Quantidade = Convert.ToInt32(txt_Quantidade_Entrada.Text) ,
                    Posicao = txt_Posicao_Entrada.Text
                };

                servico.Entrada(produto);
                MessageBox.Show("Entrada efetuada com sucesso.");
                LimparCampos();
                janelaEstoque.AtualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar: {ex.Message}" , "Erro" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }

        private void btt_Pesquisar_Click ( object sender , EventArgs e )
        {
            var produto = new Produto();
            produto.Codigo = txt_Codigo_Entrada.Text;
            label_Descricao.Text = servico.BuscarDescricao(produto.Codigo);
        }

        private void label2_Click ( object sender , EventArgs e )
        {

        }

        private void label_Descricao_Click ( object sender , EventArgs e )
        {

        }

        private void LimparCampos ()
        {
            txt_Codigo_Entrada.Clear();
            txt_Posicao_Entrada.Clear();
            txt_Quantidade_Entrada.Clear();
            label_Descricao.Text = "";
        }
    }



}
