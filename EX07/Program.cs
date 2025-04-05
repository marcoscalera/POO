using System;
using System.Collections.Generic;
using EX07;

namespace MarcosCalera_Lista
{
    class EX7
    {
        const int TAMANHO_GATOS = 3;

        public static void Main(string[] args)
        {
            ex7(); // feito
        }

        public static void ex7()
        {
            List<Animal> animais = new List<Animal>();

            for (int i = 0; i < TAMANHO_GATOS; i++)
            {
                Gato gato = new Gato();
                gato.Numero = i;
                animais.Add(gato);
            }

            Console.WriteLine("Sons dos gatos: ");
            Console.WriteLine();

            foreach (Animal animal in animais)
            {
                animal.EmitirSom();
            }
        }
    }
}