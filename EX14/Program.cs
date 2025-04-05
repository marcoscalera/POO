using System;
using System.Collections.Generic;
using EX14;

namespace MarcosCalera_Lista
{
    class EX14
    {
        public static void Main(string[] args)
        {
            ex14(); // feito
        }

        public static void ex14()
        {
            List<Circulo> circulos = new List<Circulo>();

            circulos.Add(new Circulo { Raio = 2.0 });
            circulos.Add(new Circulo { Raio = 8.0 });
            circulos.Add(new Circulo { Raio = 1.7 });
            circulos.Add(new Circulo { Raio = 5.2 });

            Console.WriteLine("===== Circulos Cadastrados =====");

            for (int i = 0; i < circulos.Count; i++)
            {
                Console.WriteLine($"\nCirculo {i + 1}");
                circulos[i].ExibirDados();
            }
        }
    }
}
