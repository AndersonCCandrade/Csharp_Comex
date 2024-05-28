using Csharp_Comex.Modelos.Produtos;

namespace Csharp_Comex.Modelos.Menus
{
    internal class Menu
    {
        List<Produto> listaDeProdutos = new List<Produto>();
        public string NomeDoSistema { get; } = "CSHARP COMEX";

        public void ExibirOpcoesDoMenu()
        {
            Console.Clear();
            Logo logo = new();
            logo.LogoSistema();
            Console.WriteLine("\nDigite 1 para cadastrar Produto");
            Console.WriteLine("Digite 2 para listar todas os produtos");
            Console.WriteLine("Digite 0 para sair");

            Console.Write("\nDigite a sua opção: ");
            int opcaoEscolhida = int.Parse(Console.ReadLine()!);



            switch (opcaoEscolhida)
            {
                case 1:
                    MenuCadatrarProduto menu1 = new();
                    listaDeProdutos.Add(menu1.CadastrarProduto());
                    break;
                case 2:
                    MenuListarProduto menu2 = new();
                    menu2.ListarProdutos(listaDeProdutos);
                    break;
                case 0:
                    Console.WriteLine($"\nObridado por usar o sistema {NomeDoSistema}.\nAté logo!");
                    break;
                default:
                    Console.WriteLine("Opção Invalida!!!");
                    break;
            }

            if (opcaoEscolhida != 0) ExibirOpcoesDoMenu();
        }

    }
}





