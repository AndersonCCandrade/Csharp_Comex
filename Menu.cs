class Menu
{
    List<Produto> listaDeProdutos = new List<Produto>();
    public string NomeDoSistema { get; } = "CSHARP COMEX";

    public void ExibirOpcoesDoMenu()
    {
        Console.Clear();
        ExibirLogo();
        Console.WriteLine("\nDigite 1 para cadastrar Produto");
        Console.WriteLine("Digite 2 para listar todas os produtos");        
        Console.WriteLine("Digite 0 para sair");

        Console.Write("\nDigite a sua opção: ");
        int opcaoEscolhida = int.Parse(Console.ReadLine()!);

        switch (opcaoEscolhida)
        {
            case 1:
                CadastrarProduto();
                break;
            case 2:
                ListarProdutos();
                break;           
            case 0:
                Console.WriteLine($"Obridado por usar o sistema {NomeDoSistema}.\n Até logo!");
                break;
            default:
                Console.WriteLine("Opção Invalida!!!");
                break;
        }
    }

    private static void ExibirLogo()
    {
        Console.WriteLine(@"
░█████╗░░░░██╗░██╗░  ░█████╗░░█████╗░███╗░░░███╗███████╗██╗░░██╗
██╔══██╗██████████╗  ██╔══██╗██╔══██╗████╗░████║██╔════╝╚██╗██╔╝
██║░░╚═╝╚═██╔═██╔═╝  ██║░░╚═╝██║░░██║██╔████╔██║█████╗░░░╚███╔╝░
██║░░██╗██████████╗  ██║░░██╗██║░░██║██║╚██╔╝██║██╔══╝░░░██╔██╗░
╚█████╔╝╚██╔═██╔══╝  ╚█████╔╝╚█████╔╝██║░╚═╝░██║███████╗██╔╝╚██╗
░╚════╝░░╚═╝░╚═╝░░░  ░╚════╝░░╚════╝░╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝" + "\n");

        Console.WriteLine("Seja bem vindo!");
    }

    private void CadastrarProduto()
    {
        Console.Clear();
        Console.WriteLine(@"
█▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ █▀█   █▀▄ █▀▀   █▀█ █▀█ █▀█ █▀▄ █░█ ▀█▀ █▀█
█▄▄ █▀█ █▄▀ █▀█ ▄█ ░█░ █▀▄ █▄█   █▄▀ ██▄   █▀▀ █▀▄ █▄█ █▄▀ █▄█ ░█░ █▄█");
        Console.Write("\nDigite o nome do produto: ");
        string nome = Console.ReadLine()!;
        Console.Write("Digite a descrição: ");
        string descricao = Console.ReadLine()!;
        Console.Write("Digite o preço: R$ ");
        float preco = float.Parse(Console.ReadLine()!);
        Console.Write("Digite a quantidade: ");
        int quantidade = int.Parse(Console.ReadLine()!);

        Produto produto = new(nome)
        {
            Descricao = descricao,
            Preco = preco,
            Quantidade = quantidade
        };


        CadastrarListaDeProdutos(produto);
        
        ExibirOpcoesDoMenu();
    }
    

    private void ListarProdutos()
    {
        Console.Clear();
        Console.WriteLine(@"
█░░ █ █▀ ▀█▀ ▄▀█   █▀▄ █▀▀   █▀█ █▀█ █▀█ █▀▄ █░█ ▀█▀ █▀█
█▄▄ █ ▄█ ░█░ █▀█   █▄▀ ██▄   █▀▀ █▀▄ █▄█ █▄▀ █▄█ ░█░ █▄█" + "\n");
        
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
        ExibirOpcoesDoMenu();
    }

    private void CadastrarListaDeProdutos(Produto produto)
    {
        listaDeProdutos.Add(produto);
    }
}






