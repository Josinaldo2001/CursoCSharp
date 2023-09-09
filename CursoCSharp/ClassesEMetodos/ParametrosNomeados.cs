using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class ParametrosNomeados
    {
        public static void FormatarData(int dia, int mes, int ano)
        {
            //Console.WriteLine($"{dia:D2}/{mes:D2}/{ano}");
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano);
        }
        public static void Executar()
        {
            FormatarData(mes: 2, dia: 5, ano: 2005);//não importa a ordem de definição
            FormatarData(ano: 2005, dia: 5, mes: 2);
            FormatarData(5,2,2005);
        }
    }
}
