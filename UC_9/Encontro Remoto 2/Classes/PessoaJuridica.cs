using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encontro_Remoto_2.Classes
{
    // classe da pessoa juridica herda da superclasse Pessoa
    public class PessoaJuridica : Pessoa
    {
        // atributos da classe pessoa
        public string? RazaoSocial { get; set; }

        public string? Cnpj { get; set; }
    }
}