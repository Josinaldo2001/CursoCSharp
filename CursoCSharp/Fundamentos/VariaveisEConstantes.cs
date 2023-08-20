using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            bool Booleano = false;
            Console.WriteLine("O valor é "+Booleano);

            //Inteiros
            byte NumByte = byte.MaxValue;
            sbyte NumSByte = sbyte.MaxValue;
            short NumShort = short.MaxValue;
            long NumLong = long.MaxValue;
            int NumInt = int.MaxValue;
            

            //Reais
            double MenValorDouble = double.MinValue;
            float MenValorFloat = float.MinValue;
            float DefinirFloat = 10.99f;
            decimal MenValorDecimal = decimal.MinValue;

            //Strings
            char ValorChar = 'a';
            string ValorString = "a";
            string MenValorString = string.Empty;

        }
    }
}
