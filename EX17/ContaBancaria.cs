using System;

namespace EX17
{
    public class ContaBancaria
    {
        public double Saldo { get; set; } 
        public double Limite { get; } = 2000;   

        public ContaBancaria(double saldoInicial = 1000)
        {
            Saldo = saldoInicial;
        }

        public bool Sacar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor inválido!");
                return false;
            }

            if (valor > Saldo + Limite)
            {
                Console.WriteLine("ERRO: Saldo + limite insuficiente!");
                return false;
            }

            Saldo -= valor;
            Console.WriteLine($"Saque de R$ {valor:F2} realizado. Saldo atual: R$ {Saldo:F2}");
            return true;
        }

        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor inválido!");
                return;
            }

            Saldo += valor;
            Console.WriteLine($"Depósito de R$ {valor:F2} realizado. Saldo atual: R$ {Saldo:F2}");
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine($"Saldo atual: R$ {Saldo:F2}");
            Console.WriteLine($"Limite disponível: R$ {Limite:F2}");
            Console.WriteLine($"Total disponível (saldo + limite): R$ {Saldo + Limite:F2}");
        }
    }
}