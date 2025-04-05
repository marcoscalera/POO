using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX07
{
    internal class Gato : Animal
    {
        public int Numero { get; set; }

        public override void EmitirSom()
        {
            Console.WriteLine($"Miau Miau! Eu sou o gato número {Numero + 1}");       
        }
    }
}
