using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresAritmeticos
    {
        public static void Executar()
        {
            var preco = 1000.0;
            int imposto = 13;
            double desconto = 0.1; //10%
            
            var TotalComDesconto = imposto + preco - preco * desconto;
            Console.WriteLine(TotalComDesconto);

            //imc
            double peso;
            double.TryParse(Console.ReadLine(), out peso);
            double Altura;
            double.TryParse(Console.ReadLine(), out Altura);

            Console.WriteLine("O imc é {0}",(peso/Math.Pow(Altura,2)).ToString("F2"));
            Console.WriteLine($"O imc é {(peso/Math.Pow(Altura,2)).ToString("#.##")}");



        }
    }
}
