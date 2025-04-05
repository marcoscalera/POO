using System;
using System.Collections.Generic;
using EX20;

namespace MarcosCalera_Lista
{
    class EX20
    {
        public static void Main(string[] args)
        {
            ex20(); // feito
        }

        public static void ex20()
        {
            Console.Write("Digite a largura do retângulo: ");
            double largura = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura do retângulo: ");
            double altura = double.Parse(Console.ReadLine());

            Retangulo retangulo = new Retangulo(largura, altura);
            Console.WriteLine($"Área do retângulo: {retangulo.CalcularArea():F2}");
            Console.WriteLine($"Perímetro do retângulo: {retangulo.CalcularPerimetro():F2}");

            Console.WriteLine("\nCírculo:");
            Console.Write("Digite o raio do círculo: ");
            double raio = double.Parse(Console.ReadLine());

            Circulo circulo = new Circulo(raio);
            Console.WriteLine($"Área do círculo: {circulo.CalcularArea():F2}");
            Console.WriteLine($"Perímetro do círculo: {circulo.CalcularPerimetro():F2}");
        }
    }
}