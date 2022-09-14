using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encontro_Remoto_2.Classes
{
    public class PessoaFisica : Pessoa
    {
        // atributos da classe Pessoa Fisica
        public string? Cpf { get; set; }

        public DateTime DataNascimento { get; set; }
        
    }
}