using Csharp_Comex.Modelos.Clientes;
using Csharp_Comex.Modelos.Menus;
using Csharp_Comex.Modelos.Produtos;

//Menu menu = new();
//menu.ExibirOpcoesDoMenu();


Cliente cliente1 = new Cliente();
cliente1.Nome = "Anderson";

Cliente cliente2 = new Cliente();
cliente2.Nome = "Davi";


Produto produto1 = new("Sapato")
{
    Descricao = "Sapato Social masculino",
    Preco = 85.55,
    Quantidade = 5
};

Produto produto2 = new("Meia")
{
    Descricao = "Sapato Social masculino",
    Preco = 15.32,
    Quantidade = 10
};

ItemDePedido itemDePedido1 = new(produto1, 8);
ItemDePedido itemDePedido2 = new(produto2, 7);

Pedido pedidoAnderson = new(cliente1);
pedidoAnderson.AdicionarItem(itemDePedido1);
pedidoAnderson.AdicionarItem(itemDePedido2);
pedidoAnderson.ExibirDetalhesDoPedido();

Console.WriteLine();

Pedido pedidoDavi = new(cliente2);
pedidoDavi.AdicionarItem(itemDePedido1);
pedidoDavi.AdicionarItem(itemDePedido2);
pedidoDavi.ExibirDetalhesDoPedido();





