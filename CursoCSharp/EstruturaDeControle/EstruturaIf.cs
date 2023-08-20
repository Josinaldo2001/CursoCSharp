using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaIf
    {
        public static void Executar()
        {
            Console.WriteLine("Digite a nota: ");

            double.TryParse(Console.ReadLine(), out double nota);

            if (nota>9)
            {
                Console.WriteLine("Parabéns");
            }
        }
    }
}
