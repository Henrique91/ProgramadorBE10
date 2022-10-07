using System.Globalization;  // Biblioteca para usar o CultureInfo    ===ToString("C", new CultureInfo("pt-BR"))===
using System.Text.RegularExpressions;  //Biblioteca para utilizar o Regex
using Encontro_Remoto_2.Classes;


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
Imposto à pagar: {metodoPF.PagarImposto(novaPessoaFisica.Rendimento).ToString("C", new CultureInfo("pt-BR"))}
Maior de idade:{metodoPF.ValidarDataNascimento(novaPessoaFisica.DataNascimento)}
Maior de idade:{(metodoPF.ValidarDataNascimento(novaPessoaFisica.DataNascimento) ? "SIM" : "NÃO")} 
Maior de idade - string:{(metodoPF.ValidarDataNascimento("05/05/1991") ? " SIM" : " NÃO")}
");

//__________________________________________________________operador ternário => ?(if) e o :(else)
// shift + alt + seta para baixo -> copia a linha

 //Instanciando um objeto do tipo pessoa juridica
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
novaPessoaJuridica.Cnpj = "58.352.125/0001-49";
novaPessoaJuridica.Rendimento = 9500.58f;
novaPessoaJuridica.Endereco = novoEndereco;

//Instanciado um objeto do tipo pessoa juridica que servirá para manipular os métodos
PessoaJuridica metodoPJ = new PessoaJuridica();

Console.WriteLine(@$"Nome Fantasia : {novaPessoaJuridica.Nome}
Razão Social : {novaPessoaJuridica.RazaoSocial}
Cnpj : {novaPessoaJuridica.Cnpj}
Cnpj Válido : {(metodoPJ.ValidarCnpj(novaPessoaJuridica.Cnpj) ? "Cnpj formato válido" : "Cnpj formato inválido")}
Rendimento Mensal: R${novaPessoaJuridica.Rendimento}
Endereço: {novaPessoaJuridica.Endereco.Logradouro},{novaPessoaJuridica.Endereco.Numero},{novaPessoaJuridica.Endereco.Complemento},{novaPessoaJuridica.Endereco.Comercial},
Imposto à pagar: R${metodoPJ.PagarImposto(novaPessoaJuridica.Rendimento)} 
");

//Imposto à pagar: {metodoPJ.PagarImposto(novaPessoaJuridica.Rendimento).ToString("C", new CultureInfo("en-US"))}

//Classe.Metodo.atributo (Acessos)

//================================================================================
// exemplo de expressão regular (Regex) para validar um formato de data

// string data = "26/09/2022";
// bool valido = Regex.IsMatch(data, @"^\d{2}/\d{2}/\d{4}$");
// Console.WriteLine(valido ? "Dentro do padrão!" : "Fora do padrão, insira novamente uma data!");

// //exemplo de subtring com dois argumentos
// //startIndex : de onde vamos partir
// // lenght : quantos caracteres vamos obter

// string nome = "Pindamonhangaba";
// string substring = nome.Substring(3,5);
// Console.WriteLine(substring);
 