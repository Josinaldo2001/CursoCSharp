using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    internal class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 14.31;

            Console.WriteLine(valor.ToString("#.###")); //três casas
            Console.WriteLine(valor.ToString("F3")); // três casas
            Console.WriteLine(valor.ToString("C")); //currency. usa a moeda padrão do computador com duas casas
            Console.WriteLine(valor.ToString("C0")); //currency. usa a moeda padrão do computador com 0 casas

            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C",cultura));

            int valor1 = 13;
            Console.WriteLine(valor1.ToString("D5")); //coloca zeros à esquerda caso o numero não tenha essa quantidade de caracteres

            
        }
    }
}
