using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaWhile
    {
        public static void Executar()
        {
            Random random = new Random();
            int NumeroSecreto = random.Next(15);

            int Palpite;
            bool NumeroEncontrado = false;
            int TentativasRestantes = 10;
            int Tentativas = 0;
            while (!NumeroEncontrado && TentativasRestantes > 0)
            {
                Console.Title = "While";
                Console.WindowWidth = 200;
                Console.Write("Insira seu palpite de um a 15. (o numero correto é {0}) ", NumeroSecreto);
                int.TryParse(Console.ReadLine(), out Palpite);
                Tentativas++;
                TentativasRestantes--;
                if (Palpite == NumeroSecreto)
                {
                    NumeroEncontrado = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Parabéns, você acertou em {0} tentativas", Tentativas);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (Palpite < NumeroSecreto)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Menor que o número secreto");
                    if (TentativasRestantes >= 0)
                        Console.WriteLine($"Restam {TentativasRestantes} tentativas");
                    else
                        Console.WriteLine("Que pena! Acabaram as tentativas");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    if (TentativasRestantes >= 0)
                    {
                        Console.WriteLine("Maior que o número secreto");
                        Console.WriteLine($"Restam {TentativasRestantes} tentativas");
                    }
                    else
                        Console.WriteLine("Que pena! Acabaram as tentativas");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }

        }
    }
}
