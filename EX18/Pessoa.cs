using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX18
{
    internal class Pessoa
    {
        public int Idade { get; set; }
        public string Nome { get; set; }

        public void ExibirDados()
        {
            Console.WriteLine($"\nNome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
        }
    }
}
