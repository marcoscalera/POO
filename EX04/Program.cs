using System;
using System.Security.Cryptography;
using EX04;

namespace MarcosCalera_Lista
{
    class EX4
    {
        public static void Main(string[] args)
        {
            ex4(); // feito
        }

        public static void ex4()
        {
            Circulo circulo = new Circulo(5.0);

            Console.WriteLine($"Círculo com raio: {circulo.Raio}");
            Console.WriteLine($"Diâmetro: {circulo.CalcularDiametro()}");
            Console.WriteLine($"Área: {circulo.CalcularArea():F2}");
        }
    }
}