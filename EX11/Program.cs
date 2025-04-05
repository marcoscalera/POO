using System;
using System.Collections.Generic;
using EX11;

namespace MarcosCalera_Lista
{
    class EX11
    {
        const int QNT_LIVROS = 2;

        public static void Main(string[] args)
        {
            ex11(); // feito
        }
        
        public static void ex11()
        {
            List<Livro> lista_livros = new List<Livro>();

            for (int i = 0; i < QNT_LIVROS; i++)
            {
                Console.WriteLine($"Dados do Livro {i + 1}");
                Livro livros = new Livro();

                Console.Write("\nDigite o Autor: ");
                livros.Autor = Console.ReadLine();

                Console.Write("Digite o Titulo: ");
                livros.Titulo = Console.ReadLine();

                Console.Write("Digite a Página: ");
                livros.Pagina = int.Parse(Console.ReadLine());

                lista_livros.Add(livros);
                Console.WriteLine();
            }

            Console.WriteLine("===== Livros Cadastrados =====");

            for (int i = 0; i < lista_livros.Count; i++)
            {
                Console.WriteLine($"\nLivro {i + 1}");
                lista_livros[i].ExibirDados();
            }
        }
    }
}