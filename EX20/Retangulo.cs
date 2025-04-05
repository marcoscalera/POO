﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX20
{
    internal class Retangulo : IForma
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }

        public double CalcularArea()
        {
            return Largura * Altura;
        }

        public double CalcularPerimetro()
        {
            return 2 * Largura * Altura;
        }
    }
}
