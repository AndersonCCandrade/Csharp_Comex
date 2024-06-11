using Csharp_Comex.Modelos.Produtos;

namespace Csharp_Comex.Modelos.Menus;

internal class MenuListarPedidos
{
    public void ListaDePedidos(List<Pedido> pedidos)
    {
        Console.Clear();
        Logo logo = new();
        logo.LogoListarPedido();
        Console.WriteLine("\n");
        if (pedidos.Count == 0)
        {
            Console.WriteLine("\nLista de pedidos vazia"); ;
        }
        else
        {
            var pedidosOrdenados = pedidos.OrderBy(p => p.Cliente.Nome).ToList();
            pedidosOrdenados.ForEach(p => Console.WriteLine(
                $" Cliente: {p.Cliente.Nome} | " +
                $"Data do Pedido: {p.Date} | " +
                $"Total de Itens: {p.Itens.Count}"));
        }
        Console.WriteLine("\nDigite uma tecla para voltar ao menur principal");
        Console.ReadKey();
    }
}
