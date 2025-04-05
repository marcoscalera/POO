using System;
using System.Security.Cryptography;
using EX03;

namespace MarcosCalera_Lista
{
    class EX3
    {
        public static void Main(string[] args)
        {
            ex3(); // feito
        }

        private static void ex3()
        {
            ContaBancaria conta = new ContaBancaria(1000.0, 500.0);

            conta.ExibirInformacoes();

            conta.Depositar(300.0);
            conta.Sacar(200.0);
            conta.Sacar(1500.0); 

            conta.ExibirInformacoes();
        }
    }
}