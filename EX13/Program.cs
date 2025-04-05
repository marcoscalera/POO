using System;
using System.Collections.Generic;
using EX13;

namespace MarcosCalera_Lista
{
    class EX13
    {
        const int QNT_FUNC = 6;

        public static void Main(string[] args)
        {
            ex13(); // feito
        }

        public static void ex13()
        {
            List<Funcionario> lista_funcionarios = new List<Funcionario>();

            for (int i = 0; i < QNT_FUNC; i++)
            {
                Console.WriteLine($"Funcionário {i + 1}");
                Funcionario funcionario = new Funcionario();

                Console.Write("Digite seu Nome: ");
                funcionario.Nome = Console.ReadLine();

                Console.Write("Digite sua Profissão: ");
                funcionario.Profissao = Console.ReadLine();

                Console.Write("Digite seu Salário (utilize vírgula para decimal): ");
                funcionario.Salario = double.Parse(Console.ReadLine());
                Console.WriteLine();

                lista_funcionarios.Add(funcionario);
            }

            Console.WriteLine("\n===== Funcionários Cadastrados =====");

            for (int i = 0; i < lista_funcionarios.Count; i++)
            {
                Console.WriteLine($"\nFuncionário {i + 1}");
                lista_funcionarios[i].ExibirDados();
            }
        }
    }
}