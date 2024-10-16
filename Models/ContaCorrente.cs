using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Dio.Models
{
    public class ContaCorrente // exemplo encapsulamento
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }
        private decimal saldo; //Encapsulamento -> ninguem consegue alterar e não e visivel fora da classe, e se altera por metodos public dentro da propria classe 

        public void RealizarSaque(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;

                Console.WriteLine($"Saque realizado!");
            }
            else{
                Console.WriteLine($"Saldo insuficiente para realizar o saque!");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"O saldo é de R${saldo}");
        }
    }
}