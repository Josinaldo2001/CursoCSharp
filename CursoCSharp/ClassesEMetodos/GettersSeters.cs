using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class GettersSeters
    {
        private class Moto
        {
            private string Marca;
            private string Modelo;
            private uint Cilindrada;

            public Moto(string marca, string modelo, uint cilindrada)
            {
                SetMarca(marca);
                SetModelo(modelo);
                SetCilindrada(cilindrada);
            }
            public Moto()
            {
            }

            public string GetMarca()
            {
                return Marca;
            }

            public void SetMarca(string marca)
            {
                Marca = marca;
            }
            public string GetModelo()
            {
                return Modelo;
            }

            public void SetModelo(string modelo)
            {
                Modelo = modelo;
            }
            public uint GetCilindrada()
            {
                return Cilindrada;
            }

            public void SetCilindrada(uint cilindrada)
            {
                //opção 1
                //if (Cilindrada>0)
                //    Cilindrada = cilindrada;

                //opção 2
                //Cilindrada= Math.Abs(cilindrada);
                Cilindrada = cilindrada;

            }
        }
        public static void Executar()
        {
            var moto1 = new Moto("Honda","CG Titan",50);

            var moto2 = new Moto();

            moto2.SetModelo("AKd");
            moto2.SetMarca("Kawasaki");
            moto2.SetCilindrada(50);

            Console.WriteLine($"{moto1.GetMarca()} {moto1.GetModelo()} {moto1.GetCilindrada()}");
            Console.WriteLine($"{moto2.GetMarca()} {moto2.GetModelo()} {moto2.GetCilindrada()}");

        }
    }
}
