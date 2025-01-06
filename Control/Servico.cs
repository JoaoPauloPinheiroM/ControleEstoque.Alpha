using Microsoft.Data.SqlClient;
using Model;
using Persistence;
using System.Reflection;
namespace Control
{
    public class Servico
    {
        private ProdutoDAL produtoDall;
        public Servico ( SqlConnection connection )
        {
            produtoDall = new ProdutoDAL(connection);
        }

        public void Entrada ( Produto produto )
        {
            produtoDall.DarEntrada(produto);
        }
        public string? BuscarDescricao ( string? codigo )
        {
            return produtoDall.BuscarDescricao(codigo);
        }
        public void Cadastrar ( Produto produto )
        {
            produtoDall.Cadastrar(produto);
        }
        public void Saida ( Produto produto )
        {
            produtoDall.FazerSaida(produto);
        }
        public void Remover ( Produto produto )
        {
            produtoDall.Remover(produto);
        }
        public List<Produto> ObterTodos ()
        {
            return produtoDall.ObterTodos();
        }
        public List<Produto> Filtrar ( string? codigo = null , string? descricao = null , string? posicao = null )
        {
            return produtoDall.Consultar(codigo , descricao , posicao);
        }
        public List<Produto> ConsultarSaldo ( List<string> codigos )
        {
            return produtoDall.ConsultarSaldo(codigos);
        }
        public void Atualizar ( Produto produto )
        {
            produtoDall.Atualizar(produto);
        }
        public void RemoverCadastro (string? codigo)
        {
            produtoDall.RemoverCadastro(codigo);
        }

        public List<Item> ObterCadastros ()
        {
           return produtoDall.ObterCadastros();
        }
        public List<Item> FiltrarCadastros(string? codigo= null, string? descricao = null)
        {
            return produtoDall.FiltrarCadastros (codigo,descricao);
        }
    }
}
