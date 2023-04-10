using System;
using System.Globalization;

namespace ExercicioBanco
{
    class ContaBancaria
    {

        public int NumeroDaConta { get; private set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numeroConta, string nomeTitular) 
        {
            NumeroDaConta = numeroConta;
            NomeTitular = nomeTitular;
        }

        public ContaBancaria(int numeroConta, string nomeTitular, double depositoInicial) : this(numeroConta, nomeTitular)
        {
            Depositar(depositoInicial);
        }

        public void Depositar(double deposito)
        {
            Saldo += deposito;
        }

        public void Sacar(double valorSaque)
        {
            if (Saldo <= (valorSaque + 5.0))
            {
                Console.WriteLine("Saldo insuficiente para saque!");
                Console.WriteLine("*Cobramos uma taxa de $5.00 para realizar a operação de saque.");

            } else
            {
                Saldo -= valorSaque + 5.0; //desconto da taxa bancária

            }
        }

        public override string ToString()
        {
            return "Conta: " + NumeroDaConta
                    + " | Titular: " + NomeTitular
                    + " | Seu saldo atual: $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);

        }

    }
    
}
