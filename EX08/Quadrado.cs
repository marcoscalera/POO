using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX08
{
    internal class Quadrado
    {
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }

        public double CalcularArea()
        {
            return Lado1 * Lado2;
        }
    }
}
