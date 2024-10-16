using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Dio.Models
{
    public class Pessoa // EX abstração -> trazer o que uma pessoa vai ter
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é: {Nome} e tenho {Idade} anos");
        }
    }
}