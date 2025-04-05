using System;
using System.Collections.Generic;
using EX08;

namespace MarcosCalera_Lista
{
    class EX8
    {
        const int QNT_QUADRADOS = 3;

        public static void Main(string[] args)
        {
            ex8(); // feito
        }

        public static void ex8()
        {
            List<Quadrado> quadrados = new List<Quadrado>();

            quadrados.Add(new Quadrado { Lado1 = 5.0, Lado2 = 5.0 }); 
            quadrados.Add(new Quadrado { Lado1 = 4.0, Lado2 = 6.0 });  
            quadrados.Add(new Quadrado { Lado1 = 3.0, Lado2 = 3.0 });  

            Console.WriteLine("\n===== Quadrados Cadastrados =====");

            for (int i = 0; i < QNT_QUADRADOS; i++)
            {
                Console.WriteLine($"\nQuadrado {i + 1}");
                Console.WriteLine($"Lado 1: {quadrados[i].Lado1}");
                Console.WriteLine($"Lado 2: {quadrados[i].Lado2}");
                Console.WriteLine($"Área: {quadrados[i].CalcularArea()}");
            }
        }
    }
}