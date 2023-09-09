using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Cliente
    {
        public string Nome;
        public readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataDeNascimento()
        {
            return String.Format($"{Nascimento.Day:D2}/{Nascimento.Month}/{Nascimento.Year}");
        }

        public Cliente()
        {

        }
    }

    class ReadOnly
    {
        public static void Executar()
        {
            var Cliente1 = new Cliente("Ana", new DateTime(2000, 12, 25));
            //Cliente1.Nascimento = new DateTime(2000, 12, 26); não funciona devido o readonly

            Console.WriteLine("{0} {1}",Cliente1.Nome,Cliente1.GetDataDeNascimento());
        }
    }
}
