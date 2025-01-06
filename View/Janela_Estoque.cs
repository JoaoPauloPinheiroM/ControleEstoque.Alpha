
using Control;
using Microsoft.Data.SqlClient;
using System.Configuration;




namespace View
{
    public partial class Janela_Estoque : Form
    {
        Servico servico;
        string connectionString = ConfigurationManager.ConnectionStrings ["CS_ADO_NET"].ConnectionString;
        public Janela_Estoque ()
        {
            InitializeComponent();
            ConfigurarAnchors();
            servico = new Servico(new SqlConnection(connectionString));
            AtualizarGrid();
        }
        private void ConfigurarAnchors ()
        {
            // === DATA GRID ===
            // Cresce pra todos os lados
            dgv_Estoque.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // === FILTROS (parte de cima) ===
            // Código e Label
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left; // fica fixo no canto superior esquerdo
            txt_Codigo_Filtro.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Descrição e Label
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            txt_Descricao_Filtro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // Repare que tô ancorando a txt_Descricao_Filtro à direita também pra ela se esticar

            // Posição e Label
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_Posicao_Filtro.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // Botão Filtrar
            btt_Filtrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // === BOTÕES DE BAIXO ===
            // btt_Cadastrar e btt_Cadastros ficam no canto inferior direito
            btt_Cadastrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btt_Cadastros.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            // btt_Entrada e btt_Saida no canto inferior esquerdo
            btt_Entrada.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btt_Saida.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;

            // btt_Consultar e btt_Movimentacao também no canto inferior esquerdo (ou onde quiser)
            btt_Consultar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btt_Movimentacao.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        }

        public void AtualizarGrid ()
        {
            // Parametros para fazer o filtro generico
            string codigoF = txt_Codigo_Filtro.Text;
            string descricaoF = txt_Descricao_Filtro.Text;
            string posicaoF = txt_Posicao_Filtro.Text;

            dgv_Estoque.DataSource = null;

            // Caso os campos text box para filtrar estejam vazios, ele chama o metodo obter todos.
            if (string.IsNullOrEmpty(codigoF) && string.IsNullOrEmpty(descricaoF) && string.IsNullOrEmpty(posicaoF))
            {

                dgv_Estoque.DataSource = servico.ObterTodos();
            }
            else
            {
                var produtosFiltrados = servico.Filtrar(codigoF , descricaoF , posicaoF);
                if (produtosFiltrados.Count == 0)
                {
                    MessageBox.Show("Nenhum produto encontrado com os filtros aplicados." , "Aviso" , MessageBoxButtons.OK , MessageBoxIcon.Warning);
                }
                dgv_Estoque.DataSource = produtosFiltrados;
            }
        }

        private void btt_Filtrar_Click ( object sender , EventArgs e )
        {
            AtualizarGrid();
        }

        private Janela_Cadastro janela_Cadastro;
        private void btt_Cadastrar_Click ( object sender , EventArgs e )
        {
            if (janela_Cadastro == null || janela_Cadastro.IsDisposed)
            {
                janela_Cadastro = new Janela_Cadastro();
                janela_Cadastro.Show();
            }
            else
            {
                janela_Cadastro.Focus();
            }
        }

        private Janela_Entrada janela_Entrada;
        private void btt_Entrada_Click ( object sender , EventArgs e )
        {

            if (janela_Entrada == null || janela_Entrada.IsDisposed)
            {
                janela_Entrada = new Janela_Entrada(this);
                janela_Entrada.Show();
            }
            else
            {
                janela_Entrada.Focus();
            }

        }


        private Janela_Saida janela_Saida;
        private void btt_Saida_Click ( object sender , EventArgs e )
        {
            if (janela_Saida == null || janela_Saida.IsDisposed)
            {
                janela_Saida = new Janela_Saida(this);
                janela_Saida.Show();
            }
            else
            {
                janela_Saida.Focus();
            }
        }

        private Janela_Cadastrados janela_Cadastrados;
        private void btt_Cadastros_Click ( object sender , EventArgs e )
        {
            if(janela_Cadastrados == null || janela_Cadastrados.IsDisposed)
            {
                janela_Cadastrados = new Janela_Cadastrados();
                janela_Cadastrados.Show();
            }
            else
            {
                janela_Cadastrados.Focus();
            }
        }
    }
}


