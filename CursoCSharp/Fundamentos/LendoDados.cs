using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    internal class LendoDados
    {
        public static void Executar()
        {
            Console.WriteLine("Qual é sua idade?");
            int idade = int.Parse(Console.ReadLine());
            //int idade = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Quanto você ganha?");
            double Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual seu nome?");
            string Nome = Console.ReadLine();

            Console.WriteLine($"{Nome} ganha {Salario} por hora. E só tem {idade} anos");
        }
    }
}
