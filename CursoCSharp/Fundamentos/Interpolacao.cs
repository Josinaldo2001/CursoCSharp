using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Interpolacao
    {
        public static void Executar()
        {
            string Nome = "inspiron";
            string Marca = "Dell";
            double Preço = 12.5;

            Console.WriteLine("O modelo "+ Nome +" da marca "+ Marca + " custa R$" + Preço);
            Console.WriteLine("O modelo {0} da marca {1} custa R${2}",Nome,Marca,Preço);
            Console.WriteLine($"O modelo {Nome} da marca {Marca} custa R${Preço}");
        }
    }
}
