using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresDeAtribuicao
    {
        public static void Executar()
        {
            int a = 5;
            a += 5;
            a++;
            Console.WriteLine(a);

            a -= 5;
            Console.WriteLine(a);

            a /= 2;
            Console.WriteLine(a);

        }
    }
}
