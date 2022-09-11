using Encontro_Remoto_2.Classes;

// imprime no console
Console.WriteLine("Hello, World!");
Console.WriteLine("=============================================");

// Para instanciar um objeto:
// Tipo NomeDo Objeto = MetodoConstrutor();

// instanciamos um objeto do tipo pessoa fisica
// ou seja, estamos criando um objeto
PessoaFisica novaPessoaFisica = new PessoaFisica();

// atribuimos um valor para as propriedades
novaPessoaFisica.Nome = "Fabi";
novaPessoaFisica.Cpf = "02342044003";
novaPessoaFisica.DataNascimento = new DateTime(1991,05,05);
novaPessoaFisica.Rendimento = 10000.50f; 

// imprimos os valores do objeto no console
Console.WriteLine("Dados da Pessoa Fisica");
Console.WriteLine("=============================================");
Console.WriteLine("Nome: " + novaPessoaFisica.Nome); // shift + alt + seta para baixo -> copia a linha
Console.WriteLine("CPF: " + novaPessoaFisica.Cpf);
Console.WriteLine("Data de Nascimento: " + novaPessoaFisica.DataNascimento);
Console.WriteLine("Rendimento: R$" + novaPessoaFisica.Rendimento);

// Exemplo de escrita com interpolação{}.
// Console.WriteLine($"Nome: {novaPessoaFisica.Nome}");
// Console.WriteLine($"Nome: {novaPessoaFisica.Cpf}");

// impressão no console com interpolação e quebra de linhas (@)
// Console.WriteLine(@$"
// Nome: {novaPessoaFisica.Nome}
// Data de Nascimento: {novaPessoaFisica.DataNascimento}
// Cpf: {novaPessoaFisica.Cpf}
// ");

PessoaJuridica  novaPessoaJuridica = new PessoaJuridica();

novaPessoaJuridica.Nome = "Senai";
novaPessoaJuridica.RazaoSocial = "Escola Senai de Informatica Ltda";
novaPessoaJuridica.Cnpj = "58352150001149";
novaPessoaJuridica.Rendimento = 100000.99f;


Console.WriteLine("=============================================");
Console.WriteLine("Dados da Pessoa Juridica");
Console.WriteLine("=============================================");
Console.WriteLine(@$"Nome Fantasia : {novaPessoaJuridica.Nome}
Razão Social : {novaPessoaJuridica.RazaoSocial}
Cnpj : {novaPessoaJuridica.Cnpj}
Rendimento Mensal: R${novaPessoaJuridica.Rendimento}
");
