using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraComum
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }
        public double Somar(double a, double b)
        {
            return a + b;
        }
        public double Multiplicar(double a, double b)
        {
            return a * b;
        }
        public double Subtrair(double a, double b)
        {
            return a - b;
        }
    }

    public class CalculadoraDeCadeia
    {
        int memoria;
        public CalculadoraDeCadeia Somar(int a)
        {
            memoria += a;
            return this; //retorna a própia calculadora
        }

        public CalculadoraDeCadeia Subtrair(int a)
        {
            memoria -= a;
            return this;
        }
        public CalculadoraDeCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }
        public int Resultado()
        {
            return memoria;
        }
        public CalculadoraDeCadeia Limpar()
        {
            memoria=0;
            return this;
        }
    }
    public class MetodosComRetorno
    {
        public static void Executar()
        {
            var calculadoraComum = new CalculadoraComum();
            int soma = calculadoraComum.Somar(5, 5);

            double.TryParse(Console.ReadLine(), out double a);
            double.TryParse(Console.ReadLine(), out double b);

            Console.WriteLine($"A soma de {a} e {b} é {calculadoraComum.Somar(a, b)}");
            Console.WriteLine($"A subtração de {a} e {b} é {calculadoraComum.Subtrair(a, b)}");
            Console.WriteLine($"A multiplicação de {a} e {b} é {calculadoraComum.Multiplicar(a, b)}");


            var calculadoraCadeia = new CalculadoraDeCadeia();
            Console.WriteLine(calculadoraCadeia.Somar(5).Subtrair(1).Multiplicar(2).Resultado());
            Console.WriteLine(calculadoraCadeia.Somar(5).Subtrair(1).Multiplicar(2).Limpar().Resultado());
        }




    }

}
