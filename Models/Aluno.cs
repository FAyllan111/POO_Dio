using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Dio.Models
{
    public class Aluno : Pessoa // herança -> herdar as informações comum de outras classes 
    {
        public double Nota { get; set; } //propriedade exclusiva de aluno

        public override void Apresentar()// mudança do apresentar usando o override para sobrescrever 
        {
            Console.WriteLine($"Olá, me chamo {Nome}, tenho {Idade}, e minha nota é {Nota}!");
        } 
    }
}