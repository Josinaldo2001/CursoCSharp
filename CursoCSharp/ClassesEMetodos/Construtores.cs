using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Carro
    {
        public string Modelo;
        public string Marca;

        //Contrutor 1
        public Carro(string modelo, string marca)
        {
            Modelo = modelo;
            Marca = marca;
        }

        //Construtor Padrão
        public Carro()
        {
        }
    }
    class Construtores
    {
        public static void Executar()
        {
            var Carro1 = new Carro("KA", "ford");
            var Carro2 = new Carro();
            Carro2.Modelo = "Siena";

        }
    }

}

