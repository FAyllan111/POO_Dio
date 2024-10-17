using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.POO_Dio.Interface;

namespace POO_Dio.Models
{
    public class Calculadora : ICaluladora // implementando interface, obriga a utlizar os mesmos metodos 
    {   
        public int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }
        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }
        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}