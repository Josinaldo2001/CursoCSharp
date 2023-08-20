using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaFor
    {
        public static void Executar()
        {
            
            Console.WriteLine("Quantos alunos a turma tem?");

            int TamanhoDaTurma;
            int.TryParse(Console.ReadLine(), out TamanhoDaTurma);
            double SomaNotas = 0;

            for (int i = 0; i < TamanhoDaTurma; i++)
            {
                int nota;
                Console.WriteLine("Digite a nota do aluno {0}",i);
                int.TryParse(Console.ReadLine(), out nota);
                SomaNotas += nota;
            }
            double Media = SomaNotas / TamanhoDaTurma;

            string Resultado = TamanhoDaTurma > 0 ? $"A média é {Media}" :"Número de alunos inválido";
            Console.WriteLine(Resultado);
        }   

    }
}
