using System;
using System.Collections.Generic;
using EX10;

namespace MarcosCalera_Lista
{
    class EX10
    {
        const int QNT_CARROS = 3;

        public static void Main(string[] args)
        {
            ex10(); // feito
        }

        public static void ex10()
        {
            List<Carro> carro_lista = new List<Carro>();

            for (int i = 0; i < QNT_CARROS; i++)
            {
                Console.WriteLine($"Dados do carro {i + 1}");
                Carro carros = new Carro();
                
                Console.Write("Digite a marca: ");
                carros.Marca = Console.ReadLine();

                Console.Write("Digite o modelo: ");
                carros.Modelo = Console.ReadLine();

                Console.Write("Digite o ano: ");
                carros.Ano = int.Parse(Console.ReadLine());

                carro_lista.Add(carros);
                Console.WriteLine();
            }

            Console.WriteLine("\n===== Carros Cadastrados =====");
            for (int i = 0; i < carro_lista.Count; i++)
            {
                Console.WriteLine($"\nCarro {i + 1}");
                carro_lista[i].ImprimirDados();
            }
        }
    }
}

