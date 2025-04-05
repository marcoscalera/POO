using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX11
{
    internal class Livro
    {
        public string Autor { get; set; }
        public string Titulo { get; set; }
        public int Pagina { get; set; }
    
        public void ExibirDados()
        {
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Titulo: {Titulo}");
            Console.WriteLine($"Página: {Pagina}");
        }
    }
}
