using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresUnarios
    {
        public static void Executar()
        {
            var ValorNegativo = -5;
            var ValorPositivo = -ValorNegativo;
            Console.WriteLine("Valor positivo {0} e valor negativo {1}",ValorPositivo, ValorNegativo);

            bool Positivo = true;
            Console.WriteLine("falso {0}", !Positivo);
        }
    }
}
