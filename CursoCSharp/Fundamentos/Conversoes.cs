using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 2;
            double casasdecimais = inteiro;
            Console.WriteLine(casasdecimais);

            double nota = 9.3;
            int notaInteira = (int) nota;
            Console.WriteLine(notaInteira);

            string ValorString = "3";
            double ValorDecimal = double.Parse(ValorString);
            Console.WriteLine(ValorDecimal);

            double ValorInteiro = Convert.ToInt32(ValorString);
            Console.WriteLine(ValorInteiro);

            int numero;
            Console.WriteLine("Digite um número");
            int.TryParse(Console.ReadLine(), out numero);

        }
    }
}
