using Csharp_Comex.Modelos.Produtos;

namespace Csharp_Comex.Modelos.Menus;

internal class MenuListarProduto : Menu
{

    public void ListarProdutos(List<Produto> listaDeProdutos)
    {
        Console.Clear();
        Logo logo = new();
        logo.LogoListarProduto();
        foreach (var produto in listaDeProdutos)
        {
            Console.WriteLine(
            $"Nome: {produto.Nome}\n" +
            $"Descrição: {produto.Descricao}\n" +
            $"Preço: R$ {produto.Preco}\n" +
            $"Quantidade: {produto.Quantidade}\n"
            );
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menur principal");
        Console.ReadKey();

    }

    public void ExibirListaDeProdutos(List<Produto> listaDeProdutos)
    {
        listaDeProdutos.ForEach(produto => Console.WriteLine(produto.ToString())); 
    }
}
