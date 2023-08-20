using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresRelacionais
    {
        public static void Executar()
        {
            Console.Write("Digite a nota: ");
            var nota = double.Parse(Console.ReadLine());
            var NotaDeCorte = 5.0;

            Console.WriteLine("Nota inválida? {0}",nota>10||nota<0);
            Console.WriteLine("Pode melhorar? {0}",nota<10);
            Console.WriteLine("Perfeito? {0}",nota==10);
            Console.WriteLine("Recuperação? {0}", nota < NotaDeCorte);

        }
    }
}
