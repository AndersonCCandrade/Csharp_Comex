using Csharp_Comex.Modelos.ConsultaApi;
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
        Console.WriteLine(requisicao.conexao().Result); 
        Console.WriteLine("\nDigite uma tecla para voltar ao menur principal");
        Console.ReadKey();

    }
}
