using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EX19
{
    internal class Cachorro : Animal
    {
        public override string EmitirSom()
        {
            return "Au Au!";
        }
    }
}
