using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX13
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public string Profissao { get; set; }
        public double Salario { get; set; }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Profissão: {Profissao}");
            Console.WriteLine($"Salário: R$ {Salario:F2}");
        }
    }
}
