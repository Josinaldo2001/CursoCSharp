﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAtributo
    {
        int a = 10;

        public static void Executar()
        {
            DesafioAtributo desafioAtributo = new DesafioAtributo();
            var A = desafioAtributo.a;
            //acessar variável dentro do método
            Console.WriteLine(A);
            
        }
    }
}
