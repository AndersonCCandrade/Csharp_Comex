// See https://aka.ms/new-console-template for more information
Console.WriteLine("Olá! Bem vindo ao Sistema Comex!\n");

//Criando objetos do tipo Cliente e Endereço

Cliente cliente1 = new Cliente();
cliente1.Nome = "Fulano de Tal";
cliente1.Cpf = "12345678998";
cliente1.Email = "fulanodetal@alura.com";
cliente1.Profissao = "Analista de Sistemas";
cliente1.Telefone = "11 98989-5656";

Endereco enderecoCliente1 = new Endereco();
enderecoCliente1.Rua = "Rua do fulano de tal";
enderecoCliente1.Numero = 520;
enderecoCliente1.Complemento = "Casa 3";
enderecoCliente1.Bairro = "Vila Fulano";
enderecoCliente1.Cidade = "São Fulano";
enderecoCliente1.Estado = "Fulano";

cliente1.Endereco = enderecoCliente1;

Console.WriteLine("Informações do Cliente\n");
cliente1.ExibirInformacaoDoCliente();