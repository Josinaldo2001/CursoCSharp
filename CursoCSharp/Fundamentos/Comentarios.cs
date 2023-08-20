using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Comentarios
    {
        //Esse é o comentário de uma linha

        /*
         * Esse é um comentário de múltiplas linhas
         * Não precisa do *, mas fica mais bonito
         */

        //Atalhos para comentar: Ctrl+K+c -> comenta
        //                       Ctrl+K+u -> desfaz o comentário

        /// <summary>
        /// A função executar cria um novo método
        /// </summary>

        public static void Executar()
        {
            Console.Write("Escreve sem criar uma nova linha");
            Console.WriteLine("Escreve sem criar uma nova linha");
            Console.WriteLine("Código claro é sempre melhor");
            Console.WriteLine("O C# tem o xml comments. Basta digitar /// e ele cria algumas tags para a documentação");
        }
    }
}
