using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Dio.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(decimal valor) //ao criar uma relação de herança é obrigatorio a implementação do metodo abstratas
        {
            saldo += valor;
        }
    }
}