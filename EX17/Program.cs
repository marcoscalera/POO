using System;
using System.Collections.Generic;
using EX17;

namespace MarcosCalera_Lista
{
    class EX17
    {
        public static void Main(string[] args)
        {
            Ex17(); // feito
        }

        public static void Ex17()
        {
            var conta = new ContaBancaria(); 

            while (true)
            {
                Console.WriteLine("\n=== MENU ===");
                Console.WriteLine("0 - Sacar");
                Console.WriteLine("1 - Depositar");
                Console.WriteLine("2 - Consultar Saldo");
                Console.WriteLine("3 - Sair");
                Console.Write("Opção: ");

                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 0) 
                {
                    Console.Write("Valor do saque: R$ ");
                    if (double.TryParse(Console.ReadLine(), out double valor))
                        conta.Sacar(valor);
                    else
                        Console.WriteLine("Valor inválido");
                }
                else if (opcao == 1)
                {
                    Console.Write("Valor do depósito: R$ ");
                    if (double.TryParse(Console.ReadLine(), out double valor))
                        conta.Depositar(valor);
                    else
                        Console.WriteLine("Valor inválido");
                }
                else if (opcao == 2) 
                {
                    conta.ConsultarSaldo();
                }
                else if (opcao == 3) 
                {
                    Console.WriteLine("Saindo...");
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida");
                }
            }
        }
    }
}