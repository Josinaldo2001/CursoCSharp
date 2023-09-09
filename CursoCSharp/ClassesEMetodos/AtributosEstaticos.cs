using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Produto
    {
        //Variáveis
        public string Nome;
        public double Preco;
        public static double Desconto;

        //construtor
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        //construtor vazio
        public Produto()
        {
        }

        public double CalcularDesconto()
        {
            return Preco - Preco * Desconto;
        }
    }

    internal class AtributosEstaticos
    {
        public static void Executar()
        {
            var produto1 = new Produto("Borracha", 2.5);
            var produto2 = new Produto()
            {
                Nome = "Lápis",
                Preco = 1.0,
            };

            Produto.Desconto = 0.3;

            Console.WriteLine(Produto.Desconto.ToString("P0"));
            Console.WriteLine("O preço de {0} com desconto de {1} é {2}", produto1.Nome,Produto.Desconto.ToString("P0"), produto1.CalcularDesconto());
        }

    }

}
