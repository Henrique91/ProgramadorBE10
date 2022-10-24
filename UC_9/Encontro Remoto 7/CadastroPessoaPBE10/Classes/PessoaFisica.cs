using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cadastro_Pessoas_PBE10.Interfaces;

namespace Encontro_Remoto_2.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        // atributos da classe Pessoa Fisica
        public string? Cpf { get; set; }

        public DateTime DataNascimento { get; set; }

        public override float PagarImposto(float rendimento)
        {
            if(rendimento <= 1500)
            {
                return 0;
            }
            else if(rendimento >= 1501 && rendimento <= 3500 )
            {
                return rendimento * 0.02f;
            }
            else if(rendimento >= 3501 && rendimento <= 6000)
            {
                return rendimento * 0.035f;
            }
            else
            {
                return rendimento * 0.05f;
            }
        }

        public bool ValidarDataNascimento(DateTime datanascimento)
        {
            //DateTime.today pega a data do sistema
            DateTime dataAtual = DateTime.Today;

            //TotalDays - converte para dias
            double anos = (dataAtual - datanascimento).TotalDays / 365;

            //Condicional para verificação
            if(anos >= 18)
            {
                return true;
            }
            //não precisamos do else, pq caso seja verdadeiro, o primeiro return é true, caso contrário, false
            return false;
        }

        public bool ValidarDataNascimento(string datanascimento)
        {
            DateTime dataConvertida;
            
            //Verificar se a string esta em um formato valido
            //DateTime.TryParse = tenta converter a string em DateTime e coloca na saída (out)
            if(DateTime.TryParse(datanascimento, out dataConvertida))
            {
                DateTime dataAtual = DateTime.Today;

                double anos = (dataAtual - dataConvertida).TotalDays / 365;

                if(anos >= 18)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}