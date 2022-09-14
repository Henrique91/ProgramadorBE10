using System.Globalization;  // Biblioteca para usar o CultureInfo    ===ToString("C", new CultureInfo("pt-BR"))===
using Encontro_Remoto_2.Classes;

// imprime no console
Console.WriteLine("=============================================");
Console.WriteLine("             Hello, World!");
Console.WriteLine("=============================================");
Console.WriteLine("          Dados da Pessoa Fisica");
Console.WriteLine("=============================================");

// // Para instanciar um objeto:
// // Tipo NomeDo Objeto = MetodoConstrutor();

// // instanciamos um objeto do tipo pessoa fisica
// // ou seja, estamos criando um objeto
PessoaFisica novaPessoaFisica = new PessoaFisica();

// // atribuimos um valor para as propriedades
novaPessoaFisica.Nome = "Henrique";
novaPessoaFisica.Cpf = "09988877700";
novaPessoaFisica.DataNascimento = new DateTime(1991,05,05);
novaPessoaFisica.Rendimento = 12000.50f; 

PessoaFisica metodoPF = new PessoaFisica();

Console.WriteLine(@$"Nome: {novaPessoaFisica.Nome}
Data de Nascimento: {novaPessoaFisica.DataNascimento}
Cpf: {novaPessoaFisica.Cpf}
Rendimento Mensal: R${novaPessoaFisica.Rendimento}
Imposto à pagar: R${metodoPF.PagarImposto(novaPessoaFisica.Rendimento)}
");

// ================imprimos os valores do objeto no console
// Console.WriteLine("Dados da Pessoa Fisica");
// Console.WriteLine("=============================================");
// Console.WriteLine("Nome: " + novaPessoaFisica.Nome); // shift + alt + seta para baixo -> copia a linha
// Console.WriteLine("CPF: " + novaPessoaFisica.Cpf);
// Console.WriteLine("Data de Nascimento: " + novaPessoaFisica.DataNascimento);
// Console.WriteLine("Rendimento: R$" + novaPessoaFisica.Rendimento);

//=================Exemplo de escrita com interpolação{}.
//Console.WriteLine($"Nome: {novaPessoaFisica.Nome}");
//Console.WriteLine($"Nome: {novaPessoaFisica.Cpf}");

//=================impressão no console com interpolação e quebra de linhas (@)

// Instanciando um objeto do tipo pessoa juridica
PessoaJuridica  novaPessoaJuridica = new PessoaJuridica();

//Instanciamos um objeto do tipo endereco
//atribuimos valores aos atributos
Endereco novoEndereco = new Endereco();

novoEndereco.Logradouro = "Rua Rio Grande do Sul";
novoEndereco.Numero = 139;
novoEndereco.Complemento = "Casa, Esteio - RS";
novoEndereco.Comercial = false;

novaPessoaJuridica.Nome = "Senai de Tecnologia";
novaPessoaJuridica.RazaoSocial = "Escola Senai de Informatica Ltda";
novaPessoaJuridica.Cnpj = "58352150001149";
novaPessoaJuridica.Rendimento = 9500.58f;
novaPessoaJuridica.Endereco = novoEndereco;

//Instanciado um objeto do tipo pessoa juridica que servirá para manipular os métodos
PessoaJuridica metodoPJ = new PessoaJuridica();


//Impressão dos valores do objeto pessoa juridica
Console.WriteLine("=============================================");
Console.WriteLine("         Dados da Pessoa Juridica");
Console.WriteLine("=============================================");
Console.WriteLine(@$"Nome Fantasia : {novaPessoaJuridica.Nome}
Razão Social : {novaPessoaJuridica.RazaoSocial}
Cnpj : {novaPessoaJuridica.Cnpj}
Rendimento Mensal: R${novaPessoaJuridica.Rendimento}
Endereço: {novaPessoaJuridica.Endereco.Logradouro},{novaPessoaJuridica.Endereco.Numero},{novaPessoaJuridica.Endereco.Complemento},{novaPessoaJuridica.Endereco.Comercial},
Imposto à pagar: R${metodoPJ.PagarImposto(novaPessoaJuridica.Rendimento)} 
");

//Imposto à pagar: {metodoPJ.PagarImposto(novaPessoaJuridica.Rendimento).ToString("C", new CultureInfo("en-US"))}

//Classe.Metodo.atributo (Acessos)


