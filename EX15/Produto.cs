using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX15
{
    internal class Produto
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double PrecoUnitario { get; set; }
        public double PrecoTotal => PrecoUnitario * Quantidade;

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Quantidade {Quantidade}");
            Console.WriteLine($"Preço Unitário: R$ {PrecoUnitario:F2}");
            Console.WriteLine($"Preço Total: R$ {PrecoTotal:F2}");
        }
    } 
}
