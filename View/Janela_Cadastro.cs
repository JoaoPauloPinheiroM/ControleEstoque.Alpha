using Control;
using Model;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace View
{
    public partial class Janela_Cadastro : Form
    {
        Servico servico;
        string connectionString = ConfigurationManager.ConnectionStrings ["CS_ADO_NET"].ConnectionString;
        public Janela_Cadastro ()
        {
            InitializeComponent();
            servico = new Servico(new SqlConnection(connectionString));
        }

        private void btt_Cadastrar_Click ( object sender , EventArgs e )
        {
            
            try
            {
                var produto = new Produto();
                produto.Codigo = txt_Codigo_Cadastro.Text;
                produto.Descricao = txt_Descricao_Cadastrar.Text;

                servico.Cadastrar(produto);
                MessageBox.Show("Cadastro feito.");
                LimparCampos();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
        }
        private void LimparCampos ()
        {
            txt_Codigo_Cadastro.Clear();
            txt_Descricao_Cadastrar.Clear();
        }
    }
}
