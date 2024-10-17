using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Dio.Models
{
    public class Professor : Pessoa // selar classes sealed -> classes nao geram herança para as demais
    {
        public Professor(string nome) : base(nome)
        {
            
        } // construtor por heranca
        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá sou {Nome}, tenho {Idade} e recebo R${Salario}");
        }
    }
}