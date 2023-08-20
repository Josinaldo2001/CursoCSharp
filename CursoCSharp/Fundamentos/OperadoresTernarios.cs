using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresTernarios
    {
        public static void Executar()
        {
            var nota = 0.0;
            string situacao = nota >= 5 ? "Aprovado" : "Reprovado";
            Console.WriteLine(situacao);
        }
    }
}
