using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro_Pessoas_PBE10.Classes
{
    static class Utils
    {
        public static void BarraDeCarregamento(string texto, int tempo, int quantidade)
        {
            Console.BackgroundColor = ConsoleColor.Red;

            Console.Write(texto);

            for (var contador = 0; contador < quantidade; contador++)
            {
                Console.Write(".");
                Thread.Sleep(tempo);

            }
            Console.ResetColor();

        }

        public static void VerificarPastaArquivo(string caminho)
        {
            string pasta = caminho.Split("/")[0];

            if(!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if(!File.Exists(caminho))
            {
                using(File.Create(caminho)){}
            }
        }

         public static void VerificarPastaArquivoPf(string caminho)
        {
            string pasta = caminho.Split("/")[0];

            if(!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if(!File.Exists(caminho))
            {
                using(File.Create(caminho)){}
            }
        }

        
    }
}