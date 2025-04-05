using System;
using System.Collections.Generic;
using EX12;

namespace MarcosCalera_Lista
{
    class EX12
    {
        public static void Main(string[] args)
        {
            ex12(); // feito
        }

        public static void ex12()
        {
            List<Triangulo> lista_triangulo = new List<Triangulo>();

            lista_triangulo.Add(new Triangulo { Base = 5.0, Altura = 5.0 });
            lista_triangulo.Add(new Triangulo { Base = 4.0, Altura = 6.0 });
            lista_triangulo.Add(new Triangulo { Base = 3.0, Altura = 3.0 });

            Console.WriteLine("===== Triângulos Cadastrados =====");

            for (int i = 0; i < lista_triangulo.Count; i++)
            {
                Console.WriteLine($"\nTriângulo {i + 1}");
                lista_triangulo[i].ExibirDados();
            }
        }
    }
}
