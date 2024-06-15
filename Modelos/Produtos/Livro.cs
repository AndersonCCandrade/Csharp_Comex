using Csharp_Comex.Modelos.Interfaces;

namespace Csharp_Comex.Modelos.Produtos;

public class Livro : Produto, IIdentifica
{
    public string Isbn { get; set; }
    public int TotalDePaginas { get; set; }

    public Livro(string nome) : base(nome)
    {
    }

    public string Identificar()
    {
        return $"Nome: {Nome} ISBN: {Isbn}";
    }
}
