using System;
using System.Collections.Generic;
using EX16;

namespace MarcosCalera_Lista
{
    class EX16
    {
        public static void Main(string[] args)
        {
            ex16(); // feito
        }

        public static void ex16()
        {
            Retangulo retangulo = new Retangulo();
            retangulo.Altura = 5.0;
            retangulo.Base = 3.0;

            double area = retangulo.CalcularArea();
            double perimetro = retangulo.CalcularPerimetro();
            Console.WriteLine($"Altura do retângulo: {retangulo.Altura}");
            Console.WriteLine($"Base do retângulo: {retangulo.Base}");
            Console.WriteLine($"Área do retângulo: {area}");
            Console.WriteLine($"Perímetro do retângulo: {perimetro}");
        }
    }
}
