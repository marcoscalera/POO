using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX19
{
    internal class Animal
    {
        public string Nome { get; set; }
        public string Especie { get; set; }

        public virtual string EmitirSom()
        {
            return "";
        }

        public void ExibirDados()
        {
            Console.WriteLine($"\nNome do cachorro: {Nome}");
            Console.WriteLine($"Espécie do cachorro: {Especie}");
            Console.WriteLine($"Seu som: {EmitirSom()}");
        }
    }
}
