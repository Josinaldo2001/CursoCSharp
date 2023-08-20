using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaIfElse
    {
        public static void Executar()
        {
            Console.WriteLine("Digite a nota de um a cinco: ");
            int.TryParse(Console.ReadLine(), out int nota);

            if (nota < 5)
            {
                Console.WriteLine("Em que podemos melhorar?");
                Console.ReadLine();
                Console.WriteLine("Vamos trabalhar nisso");

            }
            else
            {
                Console.WriteLine("Obrigado por responder");
            }

        }
    }
}
