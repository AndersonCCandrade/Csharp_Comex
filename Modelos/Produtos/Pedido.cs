using Csharp_Comex.Modelos.Clientes;

namespace Csharp_Comex.Modelos.Produtos;

internal class Pedido
{
    public Cliente Cliente { get; }
    public DateTime Date { get; }
    public List<ItemDePedido> Itens { get; }
    public double Total 
    {
        get
        {
            return Itens.Sum(itens => itens.SubTotal);
        }
    }

    public Pedido(Cliente cliente)
    {
        Cliente = cliente;
        Date = DateTime.Now;
        Itens = new List<ItemDePedido>();        
    }
    public void ExibirDetalhesDoPedido()
    {
        Console.WriteLine(
            $"Pedido do cliente -> {Cliente.Nome}           Data do Pedido: {Date}\n");
        Itens.ForEach((itens => Console.WriteLine($"item: {itens.Produto.Nome} | Quantidade: {itens.Quantidade} | Sub Total: {itens.SubTotal} ")));
        Console.WriteLine($"Valor Total do Pedido: R$ {Total}");
    }


}
