using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX12
{
    internal class Triangulo
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public void ExibirDados()
        {
            Console.WriteLine($"Tamanho da Base: {Base}");
            Console.WriteLine($"Tamanho da Altura: {Altura}");
            Console.WriteLine($"O cálculo da Área é: {(Base * Altura) / 2:F2}");
        }
    }
}
