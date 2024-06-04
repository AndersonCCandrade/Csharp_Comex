﻿using System.Text.Json.Serialization;

namespace Csharp_Comex.Modelos.Produtos;
internal class Produto 
{    
    public Produto(string nome)
    {
        Nome = nome;
    }

    [JsonPropertyName("title")]
    public string Nome { get; set; }
    [JsonPropertyName("description")]
    public string Descricao { get; set; }
    [JsonPropertyName("price")]
    public double Preco { get; set; }
    public int Quantidade { get; set; }


}