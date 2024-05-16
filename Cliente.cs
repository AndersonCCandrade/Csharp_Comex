﻿class Cliente
{
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Email { get; set; }
    public string Profissao { get; set; }
    public string Telefone { get; set; }
    public Endereco Endereco { get; set; }

    public void ExibirInformacaoDoCliente()
    {
        Console.WriteLine($"\nNome: {Nome}" +
            $"\nCPF: {Cpf}" +
            $"\nE-mail: {Email}" +
            $"\nProfissao: {Profissao}" +
            $"\nTelefone: {Telefone}" +
            $"\nEndereço:\n{Endereco.ExibirEndereco()}"
            );
    }
}