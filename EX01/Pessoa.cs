using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public void ImprimirDados()
        {
            Console.WriteLine("Dados da Pessoa:");
            Console.WriteLine($"\nNome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Telefone: {Telefone}");
            Console.WriteLine($"E-mail: {Email}");
        }
    }
}    

