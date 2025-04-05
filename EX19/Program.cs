using System;
using System.Collections.Generic;
using EX19;

namespace MarcosCalera_Lista
{
    class EX19
    {
        public static void Main(string[] args)
        {
            ex19(); // feito
        }

        public static void ex19()
        {
            Cachorro cachorro = new Cachorro();

            Console.Write("Digite o Nome do cachorro: ");
            cachorro.Nome = Console.ReadLine();

            Console.Write("Digite a Espécie do cachorro: ");
            cachorro.Especie = Console.ReadLine();

            cachorro.ExibirDados();
        }
    }
}