using Csharp_Comex.Modelos.Clientes;
using Csharp_Comex.Modelos.Produtos;


namespace Csharp_Comex.Modelos.Menus;

internal class MenuAdicionarPedido : Menu
{
    public Pedido CadastrarPedido(List<Pedido> pedidos, List<Produto> produtos)
    {
        Console.Clear();
        Logo logo = new();
        logo.LogoCadastrarPedido();

        Console.Write("\nDigite o nome do Cliente: ");
        string nome = Console.ReadLine()!;
        Cliente cliente = new();
        cliente.Nome = nome;

        bool opcao = true;
        while (opcao) 
        { 
            Console.Write("Para visualizar a lista de produtos digite 1 ou 0 para continuar: ");
            int opcaoEscolhida = int.Parse(Console.ReadLine()!);
            Console.WriteLine();
            switch (opcaoEscolhida)
            {
                case 0:
                    opcao = false;
                    break;
                case 1:
                    ExibirListaDeProdutos(produtos);
                    opcao = false;
                    break;
                default:
                    Console.WriteLine("Opção Invalida!!!");
                    break;
            }
            Console.WriteLine();
        }

        Pedido pedido = new(cliente);
        
        bool opcaoPedido = true;
        while (opcaoPedido)
        {
            Console.Write("Digite o nome do produto que deseja adicionar a lista de pedido: ");
            string nomeProduto = Console.ReadLine()!;
                     
            while (!produtos.Exists(p => p.Nome.Contains(nomeProduto)))
            {
                Console.WriteLine("Produto não encontrado!!");

                Console.Write("Digite o nome do produto que deseja adicionar a lista de pedido: ");
                nomeProduto = Console.ReadLine()!;
                                
            }

            var produto = produtos.Find(p => p.Nome == nomeProduto)!;
            Console.Write("\nDigite a quantidade do produto: ");
            int quantidade = int.Parse(Console.ReadLine()!);          

            ItemDePedido item = new(produto, quantidade);
            pedido.AdicionarItem(item);

            Console.WriteLine("Se deseja cadastrar mais algum item digite 1 senão 0");
            int opcaoCadastrarItem = int.Parse(Console.ReadLine()!);

            if (opcaoCadastrarItem == 0)
            {
                opcaoPedido = false;
            }
        }

       
        Console.Write("\nPedido Cadastrado com sucesso\n");        
        Console.WriteLine($"\nDetalhes do pedido do cliente: -> {cliente.Nome}\n");
        Console.WriteLine("__________________________________________________________\n");
        pedido.ExibirDetalhesDoPedido();
        Console.WriteLine("\n__________________________________________________________");
        Console.WriteLine("\nDigite uma tecla para voltar ao menur principal");
        Console.ReadKey();
        
        return pedido;

    }

    private void ExibirListaDeProdutos(List<Produto> produtos)
    {
        produtos.ForEach(produtos => Console.WriteLine(produtos.ToString()));
    }
}
