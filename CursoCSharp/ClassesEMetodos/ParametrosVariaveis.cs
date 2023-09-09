﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class ParametrosVariaveis
    {   
        public static void Recepcionar(params String[] pessoas)
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine("Olá, {0}",pessoa);
            }
        }

        public static void Executar()
        {
            Recepcionar("Ana", "João", "Maria", "Cristina");
        }
    }
}
