using Csharp_Comex.Modelos.Menus;
using System.Text.Json.Serialization;

namespace Csharp_Comex.Modelos.Produtos;
internal class Produto
{
    public Produto(string nome)
    {
        Nome = nome;
    }

    [JsonPropertyName("title")]
    public string Nome { get; set; }
    [JsonPropertyName("description")]
    public string Descricao { get; set; }
    [JsonPropertyName("price")]
    public double Preco { get; set; }
    public int Quantidade { get; set; }

    public static void ExibirDetalhesDoProduto(Produto produto)
    {
        Console.WriteLine($"Produto: {produto.Nome}\n" +
                          $"Descrição: {produto.Descricao}\n" +
                          $"Preço: {produto.Preco}\n");
    }

    public override string ToString()
    {
        return $"Nome: {Nome} | Descrição: {Descricao} | Preço: {Preco}";
    }
}