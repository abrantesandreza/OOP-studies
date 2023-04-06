using System;
using System.Globalization;

namespace ExercicioBanco
{
    class ContaBancaria
    {

        private int _numeroDaConta;
        private string _nomeTitular;
        private double _saldo;

        
        public ContaBancaria(int numeroDaConta, string nomeTitular, double valorDepositoInicial = 0.0)
        {

            _numeroDaConta = numeroDaConta;
            _nomeTitular = nomeTitular;
            _saldo = valorDepositoInicial;

        }

        public int NumeroDaConta
        {
            get { return _numeroDaConta;}
        }

        public string NomeTitular
        {
            get { return _nomeTitular;}
            set 
            { 
                if (value != null && value.Length > 1)
                {
                    _nomeTitular = value;
                }
            }
                
        }
        
        public double Saldo
        {
            get { return _saldo; }
        }

        public void Depositar(double deposito)
        {
            _saldo += deposito;
        }

        public void Sacar(double valorSaque)
        {
            if (_saldo <= (valorSaque + 5.0))
            {
                Console.WriteLine("Saldo insuficiente para saque!");
                Console.WriteLine("*Cobramos uma taxa de $5.00 para realizar a operação de saque.");

            } else
            {
                _saldo -= valorSaque + 5.0; //desconto da taxa bancária

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
