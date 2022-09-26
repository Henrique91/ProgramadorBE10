using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Encontro_Remoto_2.Interfaces;

namespace Encontro_Remoto_2.Classes
{
    // classe pessoa e ela é a super classe ou classe abstrata
    public abstract class Pessoa : IPessoa
    {
        // atributos da classe Pessoa
        public string? Nome { get; set; } // Digitando PROP+TAB ao criar a classe ele ja pucha a estrutura completa
        public Endereco? Endereco { get; set; } // Quando não tiver nenhum valor atribuido a variavel colocar a INTERROGAÇÃO após o tipo
        public float Rendimento { get; set; }
        public abstract float PagarImposto(float rendimento);
        
    }
}

// metodos acessores:
// get : leitura
// set ; edição
// por padrão, esses metodos acessores vem publico, mas caso necessite, coloque como privado