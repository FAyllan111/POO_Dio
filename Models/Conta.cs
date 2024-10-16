using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Dio.Models
{
    public abstract class Conta // definida como classe abstrata e usada como modelo para ser herdada e não pode ser definida pelo new Conta()
    {
        protected decimal saldo; // protejido contra alteraçoes externas menos das suas classes filhas

        public abstract void Creditar(decimal valor); // nao tem implementação é apenas a assinatura do metodo

        public void ExibirSaldo()
        {
            Console.WriteLine("O seu saldo é R$:" + saldo);
        }
    }
}