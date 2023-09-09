using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class CarroOpcional
    {
        double desconto = 0.1;
        string nome;
        public string Nome
        {
            get
            {
                return "Opcional " + nome;
            }
            set
            {
                nome = value;
            }
        }

        //Propriedade autoimplementada
        public double Preco { get; set; }

        //somente leitura (propriedades calculadas
        public double PrecoComDesconto
        {
            //get
            //{
            //    return Preco - Preco * desconto;
            //}
            get => Preco - Preco * desconto; //função lambda
        }
        //construtor 
        public CarroOpcional()
        {
        }
        public CarroOpcional(string nome, double preco)
        {
            Preco = preco;
            Nome = nome;
        }   

    }
    public class Props
    {
        public static void Executar()
        {
            var op1 = new CarroOpcional("Ar condicionado", 500);
            Console.WriteLine($"Nome {op1.Nome}");
            Console.WriteLine($"Preço: {op1.Preco:C}");
            Console.WriteLine($"Preço com desconto: {op1.PrecoComDesconto:C}");

            op1.Preco = 400;
            Console.WriteLine($"Nome {op1.Nome}");
            Console.WriteLine($"Preço: {op1.Preco:C}");
            Console.WriteLine($"Preço com desconto: {op1.PrecoComDesconto:C}");



        }
    }
}
