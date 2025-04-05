using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX14
{
    internal class Circulo
    {
        public double Raio { get; set; }

        public void ExibirDados()
        {
            Console.WriteLine($"O valor do Raio é: {Raio}");
            Console.WriteLine($"Sua Área é de: {Math.PI * (Raio * Raio):F2}");
        }
    }
}
