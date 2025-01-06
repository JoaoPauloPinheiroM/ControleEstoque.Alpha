using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model;

public class Produto
{
    public long? Id { get; set; }
    public string? Codigo { get; set; }
    public int? Quantidade { get; set; }
    public string? Descricao { get; set; }
    public string? Posicao { get; set; }

    public override bool Equals ( object? obj )
    {
        if (obj is Produto)
        {
            Produto? produto = obj as Produto;
            return this.Id.Equals(produto.Id);
        }
        return false;
    }

    public override int GetHashCode ()
    {
        return 11 + (this.Id == null ? 0 : this.Id.GetHashCode());
    }
}
