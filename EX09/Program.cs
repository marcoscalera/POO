using System;
using System.Collections.Generic;
using EX09;

namespace MarcosCalera_Lista
{
    class EX9
    {
        public static void Main(string[] args)
        {
            ex9(); // feito
        }

        public static void ex9()
        {
            List<Conta> contas = new List<Conta>();

            contas.Add(new Conta(1000.00, 500.00) { ValorDeposito = 200.00 });
            contas.Add(new Conta(2500.50, 1000.00) { ValorSaque = 300.00 });
            contas.Add(new Conta(500.00, 200.00)    { ValorDeposito = 150.00, ValorSaque = 100.00 });

            contas.Add(new Conta(15000.75, 5000.00));

            for (int i = 0; i < contas.Count; i++)
            {
                Console.WriteLine($"Conta {i + 1}: ");
                contas[i].ExibirDados();
            }
        }
    }
}
