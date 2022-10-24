using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro_Pessoas_PBE10.Interfaces
{
    public interface IPessoaFisica
    {
        /// <summary>
        /// método para validar data de nascimento
        /// </summary>
        /// <param name="datanascimento">data de nascimento</param>
        /// <returns>verdadeiro ou falso</returns>
        bool ValidarDataNascimento(DateTime datanascimento);
    }
}

//atributo: letra inicial maiuscula
//classes: letras iniciais maiusculas
//interfaces: primeira letra I + nome da classe com letra maiuscula ex: IPessoa
//metodo: iniciais maiusculas e parâmetro(argumento) em letras minusculas