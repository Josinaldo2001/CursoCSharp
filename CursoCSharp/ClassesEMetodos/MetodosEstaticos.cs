using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        public static int Soma(int a, int b)
        {
            return a + b;
        }

        public int Subtracao(int a, int b)
        {
            return a + b;
        }
    }
    public class MetodosEstaticos
    {
        public static void Executar()
        {
            //estático (acesso via instancia)
            CalculadoraEstatica calc = new CalculadoraEstatica();
            int subtrar = calc.Subtracao(4, 2);

            //estático (acesso via classe)
            int soma = CalculadoraEstatica.Soma(4, 2);
        }
    }
}


