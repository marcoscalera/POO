using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX03
{
    internal class ContaBancaria
    {
        public double Saldo { get; set; }
        public double Limite { get; set; }

        public ContaBancaria(double saldoInicial, double limite)
        {
            Saldo = saldoInicial;
            Limite = limite;
        }

        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor de depósito inválido!");
                return;
            }

            Saldo += valor;
            Console.WriteLine($"Depósito de R${valor:F2} realizado com sucesso.");
        }

        public void Sacar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor de saque inválido!");
                return;
            }

            if (valor > (Saldo + Limite))
            {
                Console.WriteLine("Saldo insuficiente para saque!");
                return;
            }

            Saldo -= valor;
            Console.WriteLine($"Saque de R${valor:F2} realizado com sucesso.");
        }
        public void ExibirInformacoes()
        {
            Console.WriteLine("\nInformações da conta:");
            Console.WriteLine($"Saldo atual: R${Saldo:F2}");
            Console.WriteLine($"Limite disponível: R${Limite:F2}");
            Console.WriteLine($"Total disponível: R${Saldo + Limite:F2}");

        }
    }
}
