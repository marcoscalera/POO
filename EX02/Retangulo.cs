using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX02
{
    internal class Retangulo
    {
        public double Altura { get; set; }
        public double Base { get; set; }

        public double CalcularArea()
        {
            return Altura * Base;
        }
    }
}
