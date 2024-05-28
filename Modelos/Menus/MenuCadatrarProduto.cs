using Csharp_Comex.Modelos.Produtos;

namespace Csharp_Comex.Modelos.Menus;

internal class MenuCadatrarProduto : Menu
{
    public Produto CadastrarProduto()
    {
        Console.Clear();
        Logo logo = new();
        logo.LogoCadastrarProduto();
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

        Console.WriteLine($"\n\nO produto {nome} foi cadastrado com sucesso!");
        Thread.Sleep(4000);

        return (produto);
    }
}

