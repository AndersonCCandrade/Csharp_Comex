using Csharp_Comex.Modelos.ConsultaApi;
using Csharp_Comex.Modelos.Filtros;
using Csharp_Comex.Modelos.Produtos;
using System.Text.Json;

namespace Csharp_Comex.Modelos.Menus;

internal class MenuExibirListaDeProdutosExterna : Menu
{
    
    public void ListarProdutosExternos()
    {

        Console.Clear();
        Logo logo = new();
        logo.LogoListaDeProdutoExternos();
        RequisicaoApi requisicao = new RequisicaoApi();
        var resultado = requisicao.conexao().Result;
        var listaDeProdutos = JsonSerializer.Deserialize<List<Produto>>(resultado)!;
        listaDeProdutos.ForEach(produto => Console.WriteLine($"Produto: {produto.Nome}\n" +
                                                         $"Descrição: {produto.Descricao}\n" +
                                                         $"Preço: {produto.Preco}\n"));
        Console.WriteLine("\nDigite uma tecla para voltar ao menur principal");
        Console.ReadKey();

    }
}
