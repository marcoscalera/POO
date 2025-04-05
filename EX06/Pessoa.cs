using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX06
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }

        public void ImprimirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Sobrenome: {Sobrenome}");
            Console.WriteLine($"Idade: {Idade}");
        }
    }
}
