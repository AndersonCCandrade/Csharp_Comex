using System.Text.Json.Serialization;

namespace Csharp_Comex.Modelos.Produtos;
internal class Produto 
{    
    public Produto(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; set; }    
    public string Descricao { get; set; }    
    public double Preco { get; set; }
    public int Quantidade { get; set; } 
  
    
}