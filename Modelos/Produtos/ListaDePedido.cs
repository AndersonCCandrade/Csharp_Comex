using System.Threading.Channels;

namespace Csharp_Comex.Modelos.Produtos;

internal class ListaDePedido
{
    public static void AdicionarPedidos(List<Pedido> pedidos, Pedido pedido)
    {
       pedidos.Add(pedido);        
    }
}
