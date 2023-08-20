using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class NotacaoPonto
    {
        public static void Executar()
        {
            var Saudacao= "Olá".ToUpper().Insert(3, " world").Replace("world","Mundo");

            Console.WriteLine(Saudacao);

            string teste = "letras";
            Console.WriteLine(teste.Length);

            string teste1 = null;
            Console.WriteLine(teste1?.Length);
        }
    }
}
