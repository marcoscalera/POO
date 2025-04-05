using System;
using System.Security.Cryptography;
using EX01;

namespace MarcosCalera_Lista
{
    class EX1
    {
        public static void Main(string[] args)
        {
            ex1(); // feito
        }

        private static void ex1()
        {
            Pessoa pessoa1 = new Pessoa();
            pessoa1.Nome = "Ramsés II";
            pessoa1.Idade = 30;
            pessoa1.Telefone = "(16) 99999-9999";
            pessoa1.Email = "ramses2@email.com";

            pessoa1.ImprimirDados();
        }
    }
}

