using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaIfElseIf
    {
        public static void Executar()
        {
            Console.WriteLine("Digite a nota de um a cinco: ");
            int.TryParse(Console.ReadLine(), out int nota);

            if (nota == 5)
            {
                Console.WriteLine("Obrigado");

            }
            else if (nota >= 3)
            {
                Console.WriteLine("Em que podemos melhorar?");
                Console.ReadLine();
            }
            else if (nota >= 1)
            {
                Console.WriteLine("Que pena! Em que podemos melhorar?");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("0?");
            }

        }
    }
}
