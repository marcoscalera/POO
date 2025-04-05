using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using EX02;

namespace MarcosCalera_Lista
{
    class EX2
    {
        public static void Main(string[] args)
        {
            ex2(); // feito
        }

        public static void ex2()
        {
            Retangulo retangulo = new Retangulo();
            retangulo.Altura = 5.0;
            retangulo.Base = 3.0;

            double area = retangulo.CalcularArea();
            Console.WriteLine($"Altura do retângulo: {retangulo.Altura}");
            Console.WriteLine($"Base do retângulo: {retangulo.Base}");
            Console.WriteLine($"Área do retângulo: {area}");
        }
    }
}
