using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaSwitch
    {
        public static void Executar()
        {
            Console.WriteLine("Digite a nota de um a cinco: ");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota)
            {
                case 0:
                    Console.WriteLine("0?");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Que pena! Em que podemos melhorar?");
                    Console.ReadLine();
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Em que podemos melhorar?");
                    Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine("Obrigado");
                    break;
                default:
                    Console.WriteLine("Nota inválida");
                    break;

            }

        }
    }
}