using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaForEach
    {
        public static void Executar()
        {
            string Palavras = "Grande dia";

            foreach (var letra in Palavras)
            {
                Console.WriteLine(letra);
            }

        }

    }
}
