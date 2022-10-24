using System.Globalization;  // Biblioteca para usar o CultureInfo    ===ToString("C", new CultureInfo("pt-BR"))===
using System.Text.RegularExpressions;  //Biblioteca para utilizar o Regex
using Cadastro_Pessoas_PBE10.Classes;
using Encontro_Remoto_2.Classes;


Console.WriteLine(@$"
=========================================
|   Bem vindo ao sistema de cadastro de |
|       Pessoa Fisica e Juridica        |
=========================================
");

Utils.BarraDeCarregamento("Inicializando", 600, 6);

//listas para armazenar as pessoas físicas cadastradas e pessoas juridicas cadastradas
List<PessoaFisica> listaPf = new List<PessoaFisica>();
List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

string? opcao;

do
{

    Console.WriteLine(@$"
=========================================
|       Escolha uma das opções abaixo   |
|----------------------------------------
|           1 - Pessoa Física           |
|           2 - Pessoa Jurídica         |
|                                       |
|           0 - Sair                    |
=========================================
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":


            string? opcaoPf;

            do
            {

                Console.WriteLine(@$"
=========================================
|       Escolha uma das opções abaixo   |
|----------------------------------------
|        1 - Cadastrar Pessoa Física    |
|        2 - Listar Pessoa Física       |
|                                       |
|        0 - Voltar ao menu anterior    |
=========================================
");

                opcaoPf = Console.ReadLine();
                PessoaFisica metodosPf = new PessoaFisica();

                switch (opcaoPf)
                {
                    case "1":
                        //Criando objetos
                        PessoaFisica novaPessoaFisica = new PessoaFisica();
                        Endereco novoEnderecoPf = new Endereco();

                        Console.WriteLine(@$"Digite o nome que deseja cadastrar:");
                        novaPessoaFisica.Nome = Console.ReadLine();

                        Console.WriteLine(@$"Digite o numero do CPF:");
                        novaPessoaFisica.Cpf = Console.ReadLine();

                        // Validação da data de nascimento

                        bool dataValida; // Váriavel que guarda a informação se a data é valida ou não

                        do
                        {
                            //entrada  e aramzenamento da data de nascimento digitada
                            Console.WriteLine(@$"Digite a data de nascimento ex: DD/MM/AAAA");
                            string? dataNascimento = Console.ReadLine();

                            //variavel recebe a validação da data de nascimento digitada
                            dataValida = metodosPf.ValidarDataNascimento(dataNascimento!);

                            //se a data for valida
                            if (dataValida)
                            {
                                //variável para armazenar a data convertida de string pra DateTime
                                DateTime dataConvertida;

                                // fazendo a conversão e colocando a saída dentro da variável dataConvertida
                                DateTime.TryParse(dataNascimento, out dataConvertida);

                                //atribui-se a data digitada para a DataNascimento do objeto
                                novaPessoaFisica.DataNascimento = dataConvertida;

                            }
                            else
                            {
                                //senão, mostra-se uma mensagem no console que a data não é válida
                                Console.WriteLine($"Data inválida, favor digitar uma data válida!");

                            }

                        } while (dataValida == false); // enquanto a dataValida for false, repetir o laço 

                        //entrada e armazenamento do rendimento
                        Console.WriteLine($"Digite o rendimento mensal - (apenas números):");
                        novaPessoaFisica.Rendimento = float.Parse(Console.ReadLine()!);

                        //entrada e armazenamento do logradouro
                        Console.WriteLine($"Digite o logradouro: ");
                        novoEnderecoPf.Logradouro = Console.ReadLine();

                        //entrada e armazenamento do número
                        Console.WriteLine($"Digite o número");
                        novoEnderecoPf.Numero = int.Parse(Console.ReadLine()!);

                        //entrada e armazenamento do complemento
                        Console.WriteLine($"Informe o complemento: ");
                        novoEnderecoPf.Complemento = Console.ReadLine();

                        //entrada e armazenamento do endereco comercial
                        Console.WriteLine($"Endereco é comercial ? S para sim ou N para não:");
                        string endCom = Console.ReadLine()!.ToUpper();

                        //se o endereço digitado for comercial "S"
                        if (endCom == "S")
                        {
                            // atribui-se true para o endereço comercial
                            novoEnderecoPf.Comercial = true;
                        }
                        else
                        {
                            //senão, atribui-se false
                            novoEnderecoPf.Comercial = false;
                        }

                        //então armazena todos os dados do objeto novoEndPf dentro do endereço do objeto novaPessoaFisica
                        novaPessoaFisica.Endereco = novoEnderecoPf;

                        //adicionamos a pessoa cadastrada dentro da lista
                        listaPf.Add(novaPessoaFisica);

                        //finalizando com uma mensagem
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro Realizado com Sucesso!!!");
                        Thread.Sleep(3000);
                        Console.ResetColor();
                        break;
                    case "2":

                        //aqui listar pf
                        if (listaPf.Count > 0)
                        {
                            foreach (PessoaFisica pf in listaPf)
                            {
                                Console.WriteLine(@$"
                                Nome: {pf.Nome}
                                CPF:{pf.Cpf}
                                Endereço: {pf.Endereco!.Logradouro}, {pf.Endereco.Numero}, {pf.Endereco.Complemento}, {pf.Endereco.Comercial}
                                Data de nascimento: {pf.DataNascimento}
                                Rendimento: R${pf.Rendimento}
                                Imposto á pagar: R${metodosPf.PagarImposto(pf.Rendimento)}
                                ");
                            }
                            Console.WriteLine($"Aperte ENTER para continuar..");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine($"Lista vazia !!!");
                        }
                        break;

                    case "0":
                        //voltar para o menu anterior
                        break;

                    default:

                        //mensagem genérica
                        Console.WriteLine($"Opção inválida, por favor digite outra opção !");
                        break;
                }
            } while (opcaoPf != "0");

        
            break;


        case "2":



            string? opcaoPj;
            

            do
            {

                Console.WriteLine(@$"
=========================================
|       Escolha uma das opções abaixo   |
|----------------------------------------
|        1 - Cadastrar Pessoa Juridica  |
|        2 - Listar Pessoa Juridica     |
|                                       |
|        0 - Voltar ao menu anterior    |
=========================================
");
                opcaoPj = Console.ReadLine();
                //Instanciado um objeto do tipo pessoa juridica que servirá para manipular os métodos
                PessoaJuridica metodoPJ = new PessoaJuridica();



                switch (opcaoPj)
                {
                    case "1":
                        //Instanciando um objeto do tipo pessoa juridica
                        PessoaJuridica novaPessoaJuridica = new PessoaJuridica();
                        //Instanciamos um objeto do tipo endereco
                        Endereco novoEndereco = new Endereco();

                        Console.WriteLine($"Digite o nome fantasia que deseja cadastrar:");
                        novaPessoaJuridica.Nome = Console.ReadLine();

                        Console.WriteLine($"Digite a razão social da empresa:");
                        novaPessoaJuridica.RazaoSocial = Console.ReadLine();

                        bool cnpjValido; // variavel para guardar se o cnpj é valido ou não

                        do
                        {
                            Console.WriteLine($"Digite seu CNPJ ex: NN.NNN.NNN/NNNN-NN ");
                            string? numeroCnpj = Console.ReadLine();

                            cnpjValido = metodoPJ.ValidarCnpj(numeroCnpj!);

                            if (cnpjValido)
                            {

                                novaPessoaJuridica.Cnpj = numeroCnpj;
                            }
                            else
                            {
                                Console.WriteLine($"Cnpj inválido, favor digitar um cnpj válido!");

                            }
                        } while (cnpjValido == false);

                        Console.WriteLine($"Digite o logradouro:");
                        novoEndereco.Logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o numero:");
                        novoEndereco.Numero = int.Parse(Console.ReadLine()!);

                        Console.WriteLine($"Digite um complemento");
                        novoEndereco.Complemento = Console.ReadLine();

                        Console.WriteLine($"Endereço é comercial? S para sim ou N para não");
                        string endComPj = Console.ReadLine()!.ToUpper();

                        if (endComPj == "S")
                        {
                            novoEndereco.Comercial = true;
                        }
                        else
                        {
                            novoEndereco.Comercial = false;
                        }

                        novaPessoaJuridica.Endereco = novoEndereco;

                        //adiciona a pessoa cadastrada dentro da lista

                        listaPj.Add(novaPessoaJuridica);

                        Console.WriteLine($"Digite seu rendimento mensal");
                        novaPessoaJuridica.Rendimento = int.Parse(Console.ReadLine()!);

                        break;
                    case "2":

                        if (listaPj.Count > 0)
                        {
                            foreach (PessoaJuridica pj in listaPj)
                            {
                                Console.WriteLine(@$"
                                Nome: {pj.Nome}
                                Razão Social: {pj.RazaoSocial}
                                CNPJ: {pj.Cnpj}
                                Endereço: {pj.Endereco!.Logradouro}, {pj.Endereco.Numero}, {pj.Endereco.Complemento}, {pj.Endereco.Comercial}
                                Rendimento Mensal: R${pj.Rendimento}
                                Imposto à pagar: R${metodoPJ.PagarImposto(pj.Rendimento)}

                                ");

                            }
                            Console.WriteLine($"Aperte enter para continuar...");
                            Console.ReadLine();

                        }
                        else
                        {
                            Console.WriteLine($"Lista vazia!");

                        }

                        break;
                    case "0":
                        // caso 0 - voltar para o menu anterior
                        break;
                    default:
                        Console.WriteLine($"Opção inválida, favor digitar outra opção!");

                        break;
                }


            } while (opcaoPj != "0");
            break;





        case "0":
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Obrigado por utilizar nosso sistema!");
            Console.ResetColor();
            Thread.Sleep(3000);
            break;

        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Opção inválida, escolha outra opção!");
            Console.ResetColor();
            Thread.Sleep(800);
            break;
    }
} while (opcao != "0");

Utils.BarraDeCarregamento("Finalizando", 500, 6);
Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine($"FINALIZADO");
Console.ResetColor();








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












//     novoEndereco.Logradouro = "Rua Rio Grande do Sul";
//     novoEndereco.Numero = 139;
//     novoEndereco.Complemento = "Casa, Esteio - RS";
//     novoEndereco.Comercial = false;

//     novaPessoaJuridica.Nome = "Senai de Tecnologia";
//     novaPessoaJuridica.RazaoSocial = "Escola Senai de Informatica Ltda";
//     novaPessoaJuridica.Cnpj = "58.352.125/0001-49";
//     novaPessoaJuridica.Rendimento = 9500.58f;
//     novaPessoaJuridica.Endereco = novoEndereco;


//     Console.WriteLine(@$"Nome Fantasia : {novaPessoaJuridica.Nome}
// Razão Social : {novaPessoaJuridica.RazaoSocial}
// Cnpj : {novaPessoaJuridica.Cnpj}
// Cnpj Válido : {(metodoPJ.ValidarCnpj(novaPessoaJuridica.Cnpj) ? "Cnpj formato válido" : "Cnpj formato inválido")}
// Rendimento Mensal: R${novaPessoaJuridica.Rendimento}
// Endereço: {novaPessoaJuridica.Endereco.Logradouro},{novaPessoaJuridica.Endereco.Numero},{novaPessoaJuridica.Endereco.Complemento},{novaPessoaJuridica.Endereco.Comercial},
// Imposto à pagar: R${metodoPJ.PagarImposto(novaPessoaJuridica.Rendimento)} 
// ");