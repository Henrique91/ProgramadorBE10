using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Cadastro_Pessoas_PBE10.Interfaces;

namespace Encontro_Remoto_2.Classes
{
    // classe da pessoa juridica herda da superclasse Pessoa
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        // atributos da classe pessoa
        public string? RazaoSocial { get; set; }

        public string? Cnpj { get; set; }

        public override float PagarImposto(float rendimento)
        {
            if(rendimento <= 3000)
            {
                return rendimento * 0.03f;
            }
            else if(rendimento >= 3001 && rendimento <= 6000 )
            {
                return rendimento * 0.05f;
            }
            else if(rendimento >= 6001 && rendimento <= 10000)
            {
                return rendimento * 0.07f;
            }
            else
            {
                return rendimento * 0.09f;
            }
        }

        //https://www.macoratti.net/11/09/c_val1.htm 
        // https://learn.microsoft.com/pt-br/dotnet/standard/base-types/regular-expressions
        //https://learn.microsoft.com/pt-br/dotnet/api/system.text.regularexpressions.regex?view=net-6.0
        //https://learn.microsoft.com/pt-br/dotnet/api/system.string.substring?view=net-6.0
        
        //58.635.559/0001-55 : 18 caracteres
        //58635559000155 : 14 caracteres
        
        public bool ValidarCnpj(string cnpj)  
        {
            if(Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)"))
            {
                if(cnpj.Length == 18)
                {
                    if(cnpj.Substring(11, 4) == "0001")
                    {
                        return true;
                    }
                }
                else if(cnpj.Length == 14)
                {
                    if(cnpj.Substring(8, 4) == "0001")
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}