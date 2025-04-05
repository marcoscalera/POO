using System;
using System.Collections.Generic;
using EX18;

namespace MarcosCalera_Lista
{
    class EX18
    {
        public static void Main(string[] args)
        {
            ex18(); // feito
        }

        public static void ex18()
        {
            Pessoa pessoa = new Pessoa();

            Console.Write("Digite seu nome: ");
            pessoa.Nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            pessoa.Idade = int.Parse(Console.ReadLine());

            pessoa.ExibirDados();
        }
    }
}