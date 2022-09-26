using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encontro_Remoto_2.Classes
{
    public class Endereco // Classe para endereço
    {
        //atributos da classe endereço
        public string? Logradouro { get; set; }
        public int Numero { get; set; }
        public string? Complemento { get; set; }
        public bool Comercial { get; set; }  
    }
}