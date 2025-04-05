using System;
using System.Collections.Generic;
using EX05;

namespace MarcosCalera_Lista
{
    class EX5
    {
        const double MEDIA_APROVACAO = 6.0;

        public static void Main(string[] args)
        {
            ex5();
        }

        public static void ex5()
        {
            List<Aluno> alunos = new List<Aluno>();

            int tam_alunos = 5;

            for (int i = 0; i < tam_alunos; i++)
            {
                Console.WriteLine($"\nAluno {i + 1}:");
                alunos.Add(new Aluno().Cadastrar());
            }

            Console.WriteLine("\n=== RESULTADOS ===");
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"\n{aluno.Nome}");
                Console.WriteLine($"Notas: {string.Join(", ", aluno.Notas)}");
                Console.WriteLine($"Média: {aluno.CalcularMedia():F1} - {(aluno.CalcularMedia() >= MEDIA_APROVACAO ? "Aprovado" : "Reprovado")}");
            }
        }
    }
}