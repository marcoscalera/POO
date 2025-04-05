using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX05
{
    internal class Aluno
    {

        const int QUANTIDADE_NOTAS = 5;

        public string Nome;
        public double[] Notas = new double[QUANTIDADE_NOTAS];

        public Aluno Cadastrar()
        {
            Console.Write("Nome: ");
            Nome = Console.ReadLine();

            for (int i = 0; i < QUANTIDADE_NOTAS; i++)
            {
                Console.Write($"Nota {i + 1}: ");
                Notas[i] = Convert.ToDouble(Console.ReadLine());
            }

            return this;
        }

        public double CalcularMedia()
        {
            double soma = 0;
            foreach (var nota in Notas) soma += nota;
            return soma / QUANTIDADE_NOTAS;
        }
    }
}
