using Model;
using Microsoft.Data.SqlClient;
using Dapper;
using System.Data;
using System.ComponentModel.DataAnnotations;
public struct Item
{
    public string Codigo { get; set; }
    public string Descricao { get; set; }
}

namespace Persistence
{
    public class ProdutoDAL
    {
        private readonly SqlConnection connection;

        public ProdutoDAL ( SqlConnection connection )
        {
            this.connection = connection;
        }

        public string? BuscarDescricao ( string codigo , IDbTransaction? transaction = null )
        {
            try
            {
                if (transaction == null)
                {
                    connection.Open();
                    var result = connection.QuerySingleOrDefault<string>(
                        "SELECT descricao FROM CADASTROS WHERE codigo = @codigo" ,
                        new { codigo }
                    );
                    connection.Close();
                    return result;
                }
                else
                {
                    return connection.QuerySingleOrDefault<string>(
                        "SELECT descricao FROM CADASTROS WHERE codigo = @codigo" ,
                        new { codigo } ,
                        transaction
                    );
                }
            }
            catch
            {
                return null;
            }
        }

        public void DarEntrada ( Produto produto )
        {
            connection.Open();
            using var transaction = connection.BeginTransaction();
            try
            {
                var atual = connection.QuerySingleOrDefault<int?>(
                    "SELECT Quantidade FROM Estoque WHERE Codigo = @codigo AND Posicao = @posicao" ,
                    new { produto.Codigo , produto.Posicao } ,
                    transaction
                );

                if (atual.HasValue)
                {
                    connection.Execute(
                        "UPDATE Estoque SET Quantidade = @qtd WHERE Codigo = @codigo AND Posicao = @posicao" ,
                        new { qtd = atual.Value + produto.Quantidade , produto.Codigo , produto.Posicao } ,
                        transaction
                    );
                }
                else
                {
                    var desc = BuscarDescricao(produto.Codigo , transaction) ?? "SEM_DESCRICAO";
                    connection.Execute(
                        "INSERT INTO Estoque (Codigo, Descricao, Quantidade, Posicao) VALUES (@c,@d,@q,@p)" ,
                        new { c = produto.Codigo , d = desc , q = produto.Quantidade , p = produto.Posicao } ,
                        transaction
                    );
                }

                RegistrarEntradas(produto , transaction);
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception($"Erro ao dar entrada: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        private void RegistrarEntradas ( Produto produto , IDbTransaction transaction )
        {
            var desc = BuscarDescricao(produto.Codigo , transaction) ?? "SEM_DESCRICAO";
            connection.Execute(
                @"INSERT INTO Entradas (codigo, descricao, quantidade, posicao) 
          VALUES (@c, @d, @q, @p)" ,
                new { c = produto.Codigo , d = desc , q = produto.Quantidade , p = produto.Posicao } ,
                transaction
            );
        }

        public List<Produto> Consultar ( string? codigo = null , string? descricao = null , string? posicao = null )
        {
            try
            {
                connection.Open();
                var sql = "SELECT codigo, descricao, quantidade, posicao FROM Estoque WHERE 1=1";
                if (!string.IsNullOrEmpty(codigo)) sql += " AND codigo = @codigo";
                if (!string.IsNullOrEmpty(descricao)) sql += " AND descricao LIKE @descricao";
                if (!string.IsNullOrEmpty(posicao)) sql += " AND posicao = @posicao";
                var lista = connection.Query<Produto>(
                    sql ,
                    new { codigo , descricao = $"%{descricao}%" , posicao }
                ).ToList();
                connection.Close();
                return lista;
            }
            catch
            {
                connection.Close();
                return new List<Produto>();
            }
        }

        public List<Item> FiltrarCadastros ( string? codigo = null , string? descricao = null)
        {
            try
            {
                connection.Open();
                var sql = "SELECT codigo, descricao FROM Cadastros WHERE 1=1";
                if (!string.IsNullOrEmpty(codigo)) sql += " AND codigo = @codigo";
                if (!string.IsNullOrEmpty(descricao)) sql += " AND descricao LIKE @descricao";
                
                var lista = connection.Query<Item>(
                    sql ,
                    new { codigo , descricao = $"%{descricao}%"}
                ).ToList();
                connection.Close();
                return lista;
            }
            catch
            {
                connection.Close();
                return new List<Item>();
            }
        }
        public List<Produto> ConsultarSaldo ( List<string> codigos )
        {
            try
            {
                connection.Open();
                var lista = connection.Query<Produto>(
                    "SELECT codigo, SUM(quantidade) AS Quantidade FROM Estoque WHERE codigo IN @c GROUP BY codigo" ,
                    new { c = codigos }
                ).ToList();
                connection.Close();
                return lista;
            }
            catch
            {
                connection.Close();
                return new List<Produto>();
            }
        }

        public void Cadastrar ( Produto produto )
        {
            try
            {
                connection.Open();
                connection.Execute(
                    "INSERT INTO CADASTROS (codigo, descricao) VALUES (@c, @d)" ,
                    new { c = produto.Codigo , d = produto.Descricao }
                );
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao cadastrar: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        public void Atualizar ( Produto produto )
        {
            try
            {
                connection.Open();
                var desc = BuscarDescricao(produto.Codigo) ?? "SEM_DESCRICAO";
                connection.Execute(
                    "UPDATE Estoque SET quantidade=@q, descricao=@d, posicao=@p WHERE codigo=@c AND posicao=@p" ,
                    new { q = produto.Quantidade , d = desc , p = produto.Posicao , c = produto.Codigo }
                );
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao atualizar: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        public void Remover ( Produto produto )
        {
            try
            {
                connection.Open();
                connection.Execute(
                    "DELETE FROM Estoque WHERE codigo=@c AND posicao=@p" ,
                    new { c = produto.Codigo , p = produto.Posicao }
                );
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao remover: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        public void RemoverCadastro ( string? codigo)
        {
            try
            {
                connection.Open();
                connection.Execute(
                    "DELETE FROM Cadastros WHERE codigo=@c" ,
                    new { c = codigo}
                );
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao remover: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
        public void FazerSaida ( Produto produto )
        {
            connection.Open();
            using var transaction = connection.BeginTransaction();
            try
            {
                var atual = connection.QuerySingleOrDefault<int?>(
                    "SELECT quantidade FROM Estoque WHERE codigo=@c AND posicao=@p" ,
                    new { c = produto.Codigo , p = produto.Posicao } ,
                    transaction
                );

                if (!atual.HasValue) { transaction.Rollback(); return; }
                if (atual.Value < produto.Quantidade) { transaction.Rollback(); return; }

                var desc = BuscarDescricao(produto.Codigo , transaction) ?? "SEM_DESCRICAO";
                connection.Execute(
                    "INSERT INTO SAIDAS (codigo, descricao, quantidade, posicao) VALUES (@c,@d,@q,@p)" ,
                    new { c = produto.Codigo , d = desc , q = produto.Quantidade , p = produto.Posicao } ,
                    transaction
                );
                if ((atual.Value - produto.Quantidade) == 0)
                {
                    connection.Execute(
                        "DELETE FROM Estoque  WHERE codigo=@c AND posicao=@p" ,
                        new { c = produto.Codigo , p = produto.Posicao } ,
                        transaction
                    );
                }
                connection.Execute(
                    "UPDATE Estoque SET quantidade=@nq WHERE codigo=@c AND posicao=@p" ,
                    new { nq = atual.Value - produto.Quantidade , c = produto.Codigo , p = produto.Posicao } ,
                    transaction
                );

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception($"Erro ao fazer saída: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Item> ObterCadastros ()
        {

            
            List<Item> produtos = new List<Item>();
                var command = new SqlCommand("SELECT Codigo, Descricao FROM CADASTROS" , connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var produto = new Item();
                        produto.Codigo = reader.GetString(0);
                        produto.Descricao = reader.GetString(1);
                        produtos.Add(produto);
                    }
                }
                connection.Close();
                return produtos;
            
        }
        public List<Produto> ObterTodos ()
        {
            List<Produto> produtos = new List<Produto>();
            var command = new SqlCommand("SELECT Id, Codigo, Descricao, Quantidade, Posicao FROM ESTOQUE" , connection);
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var produto = new Produto();
                    produto.Id = reader.GetInt32(0);
                    produto.Codigo = reader.GetString(1);
                    produto.Descricao = reader.GetString(2);
                    produto.Quantidade = reader.GetInt32(3);
                    produto.Posicao = reader.GetString(4);
                    produtos.Add(produto);
                }
            }
            connection.Close();
            return produtos;


        }

    }
}
