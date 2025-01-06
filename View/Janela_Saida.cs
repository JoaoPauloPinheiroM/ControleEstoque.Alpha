using Model;
using Control;
using Microsoft.Data.SqlClient;
using System.Configuration;





namespace View
{
    public partial class Janela_Saida : Form
    {
        private Janela_Estoque janela_Estoque;
        Servico servico;
        string connectionString = ConfigurationManager.ConnectionStrings ["CS_ADO_NET"].ConnectionString;
        public Janela_Saida ( Janela_Estoque janelaEsoque )
        {
            InitializeComponent();
            servico = new Servico(new SqlConnection(connectionString));
            janela_Estoque = janelaEsoque;
        }

        private void btt_Executar_Click ( object sender , EventArgs e )
        {
            try
            {
                var produto = new Produto
                {
                    Codigo = txt_Codigo_Saida.Text ,
                    Quantidade = Convert.ToInt32(txt_Quantidade_Saida.Text) ,
                    Posicao = txt_Posicao_Saida.Text
                };
                // caso a saída e o estoque atual da posicao do produto seja 0, o registro dele deve ser apagado do view.
                servico.Saida(produto);
                MessageBox.Show("Saída efetuada com sucesso.");
                LimparCampos();
                janela_Estoque.AtualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar: {ex.Message}" , "Erro" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }

        private void btt_Pesquisar_Click ( object sender , EventArgs e )
        {
            var produto = new Produto();
            produto.Codigo = txt_Codigo_Saida.Text;


            // codigo para poder buscar a quantidade disponivel na posicao que deseja fazer a saida.
            int? quantidadeDisponivel = 0;
            List<Produto> produtos = new List<Produto>();
            produtos = servico.Filtrar(codigo: txt_Codigo_Saida.Text , posicao: txt_Posicao_Saida.Text);

            foreach (var item in produtos)
            {
                quantidadeDisponivel += item.Quantidade;
            }
            label_Descricao_Saida.Text = servico.BuscarDescricao(produto.Codigo);
            label_Quantidade_Saida.Text = quantidadeDisponivel.ToString();

        }

        private void LimparCampos ()
        {
            txt_Codigo_Saida.Clear();
            txt_Quantidade_Saida.Clear();
            txt_Posicao_Saida.Clear();
            label_Descricao_Saida.Text = "";
            label_Quantidade_Saida.Text = "";
        }
    }
}
