using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Dio.Interface
{
    public interface iCalculadora
    {
        int Somar(int num1, int num2);// metodos obrigatotios
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);
        int Dividir(int num1, int num2);
        // metodos sem corpo sao opcionais a implementacao
    }
}