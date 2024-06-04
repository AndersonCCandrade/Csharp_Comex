using Csharp_Comex.Modelos.Filtros;
using Csharp_Comex.Modelos.Produtos;

namespace Csharp_Comex.Modelos.Menus;

internal class MenuExibirListaDeProdutosOrdenados : Menu
{
    public void ListaDeProdutosOrdenadosPorNome(List<Produto> produtos)
    {
        var listaDeProdutos = OrdenacaoDeProdutos.ExibirListaDeProdutosOrdendaPorNome(produtos);
        ExibirListaDeProdutos(listaDeProdutos);
    }

    public void ListaDeProdutosOrdenadosPorPreco(List<Produto> produtos)
    {
        var listaDeProdutos = OrdenacaoDeProdutos.ExibirListaDeProdutosOrdendaPeloPreco(produtos);
        ExibirListaDeProdutos(listaDeProdutos);
    }

    private void ExibirListaDeProdutos(List<Produto> produtos)
    {
        Console.Clear();
        Logo logo = new();
        logo.LogoListarProduto();
        produtos.ForEach(produto => Console.WriteLine($"Produto: {produto.Nome}\n" +
                                                      $"Descrição: {produto.Descricao}\n" +
                                                      $"Preço: {produto.Preco}\n"));

        Console.WriteLine("\nDigite uma tecla para voltar ao menur principal");
        Console.ReadKey();
    }
}