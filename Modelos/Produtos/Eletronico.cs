﻿namespace Csharp_Comex.Modelos.Produtos;

internal class Eletronico : Produto
{
    public int Voltagem { get; set; }
    public int Potencia { get; set; }

    public Eletronico(string nome) : base(nome)
    {
    }
}