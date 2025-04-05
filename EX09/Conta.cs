using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX09
{
    internal class Conta
    {
        public double ValorSaque { get; set; }
        public double ValorDeposito { get; set; }
        public double Saldo { get; set; }
        public double Limite { get; set; }

        public Conta (double saldoInicial, double limite)
        {
            Saldo = saldoInicial;
            Limite = limite;
            ValorSaque = 0;
            ValorDeposito = 0;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Saldo: R$ {Saldo:F2}");
            Console.WriteLine($"Limite: R$ {Limite:F2}");
            Console.WriteLine($"Último saque: R$ {ValorSaque:F2}");
            Console.WriteLine($"Último depósito: R$ {ValorDeposito:F2}");
            Console.WriteLine("===========");
        }
    }
}
