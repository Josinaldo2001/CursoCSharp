using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Pessoa
    {
        public string Nome = null;
        public int Idade;

        public string Apresentar()
        {
            return string.Format($"Olá. me chamo {Nome} e tenho {Idade} anos");
        }

        public void ApresentarNoControle()
        {
            Console.WriteLine(Apresentar());
        }

    }
}
