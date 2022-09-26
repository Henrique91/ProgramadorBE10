using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro_Pessoas_PBE10.Interfaces
{
    public interface IPessoaJuridica
    {
        /// <summary>
        /// metodo para validar cnpj
        /// </summary>
        /// <param name="cnpj">cnpj da pessoa juridica</param>
        /// <returns>verdadeiro ou falso</returns>
        bool ValidarCnpj(string cnpj);
    }
}


//atributo: letra inicial maiuscula
//classes: letras iniciais maiusculas
//interfaces: primeira letra I + nome da classe com letra maiuscula ex: IPessoa
//metodo: iniciais maiusculas e parâmetro(argumento) em letras minusculas