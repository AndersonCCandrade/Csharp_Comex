namespace Csharp_Comex.Modelos.Produtos;

internal class Livro : Produto
{
    public string Isbn { get; set; }
    public int TotalDePaginas { get; set; }

    public Livro(string nome) : base(nome)
    {
    }
}
