using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Dio.Models
{
    public class Diretor : Professor
    {
        public sealed override void Apresentar() // metodos  seladas não podem ser sobreescritos
        {
            Console.WriteLine($"Sou diretor");
        }
    }
}