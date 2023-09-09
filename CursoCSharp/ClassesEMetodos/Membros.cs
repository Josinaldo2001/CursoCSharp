using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa Sicrano = new Pessoa();
            Pessoa Fulano = new Pessoa();
            Sicrano.Nome = "fulano";
            Fulano.Nome = "fulano";
            Sicrano.Idade = 15;
            Fulano.Idade = 10;

            Console.WriteLine(Fulano.Apresentar());
            Fulano.ApresentarNoControle();
        }



    }
}
