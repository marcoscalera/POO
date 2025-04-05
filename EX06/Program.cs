using System;
using System.Collections.Generic;
using EX06;

namespace MarcosCalera_Lista
{
    class EX6
    {
        const int TAMANHO = 5; 

        public static void Main(string[] args)
        {
            ex6();
        }

        public static void ex6()
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            for (int i = 0; i < TAMANHO; i++)
            {
                Console.WriteLine($"\nDados da pessoa {i + 1}");
                Pessoa pessoa = new Pessoa();

                Console.Write("Nome: ");
                pessoa.Nome = Console.ReadLine();

                Console.Write("Sobrenome: ");
                pessoa.Sobrenome = Console.ReadLine();

                Console.Write("Idade: ");
                pessoa.Idade = int.Parse(Console.ReadLine());

                pessoas.Add(pessoa);
            }

            Console.WriteLine("\n=== Pessoas Cadastradas ===");
            for (int i = 0; i < pessoas.Count; i++)
            {
                Console.WriteLine($"\nPessoa {i + 1}:");
                pessoas[i].ImprimirDados();
            }
        }
    }
}