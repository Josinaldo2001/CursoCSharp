using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public enum Genero { Acao, Aventura, Comedia };
    public class Filme
    {
        public Genero Genero;
        public string Nome;

        public Filme(Genero genero, string nome)
        {
            Genero = genero;
            Nome = nome;
        }
    }

    internal class ExemploEnum
    {
        public static void Executar()
        {
            var Filme1 = new Filme(Genero.Aventura, "Soul");
            int Id = (int)Filme1.Genero;
            Console.WriteLine($"{Filme1.Genero} tem o ID {Id}");
        }

    }
}
