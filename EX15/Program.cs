using System;
using System.Collections.Generic;
using EX15;

namespace MarcosCalera_Lista
{
    class EX15
    {
        public static void Main(string[] args)
        {
            ex15(); // feito
        }

        public static void ex15()
        {
            List<Produto> produto = new List<Produto>();

            produto.Add(new Produto { Nome = "Banana", Quantidade = 5, PrecoUnitario = 2.5 });
            produto.Add(new Produto { Nome = "Laranja", Quantidade = 15, PrecoUnitario = 1.5 });
            produto.Add(new Produto { Nome = "Morango", Quantidade = 3, PrecoUnitario = 9 });
            produto.Add(new Produto { Nome = "Melancia", Quantidade = 1, PrecoUnitario = 8.55 });
            produto.Add(new Produto { Nome = "Tomate", Quantidade = 6, PrecoUnitario = 2.3 });

            Console.WriteLine("===== Produtos Cadastrados =====");

            for (int i = 0; i < produto.Count; i++)
            {
                Console.WriteLine($"\nProduto {i + 1}");
                produto[i].ExibirDados();
            }
        }
    }
}
