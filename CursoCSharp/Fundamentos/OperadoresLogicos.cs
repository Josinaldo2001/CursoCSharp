using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresLogicos
    {   
        public static void Executar()
        {
            bool Trabalho1 = false;
            bool Trabalho2 = false;

            var TV50 = Trabalho1==true && Trabalho2==true;
            var TV32 = Trabalho1 == true ^ Trabalho2 == true;
            var sorvete = Trabalho1==true || Trabalho2 == true;

            Console.WriteLine("TV50 {0}", TV50);    
            Console.WriteLine("TV32 {0}", TV32);
            Console.WriteLine("Sorvete {0}", sorvete);
        }
    }
}
