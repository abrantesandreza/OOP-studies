using ExercicioBanco;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Vamos criar a sua conta!");
            Console.WriteLine();
            Console.Write("Entre o número da sua conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nomeTitular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char userResponse = char.Parse(Console.ReadLine());

            //Valor default para o saldo
            double valorDepositoInicial = 0.0;

            //Caso exista valor depositado no momento da criação da conta
            if (userResponse == 's' || userResponse == 'S')
            {
                Console.Write("Entre o valor do depósito inicial: ");
                valorDepositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            //Instanciando a classe ContaBancaria
            ContaBancaria contaBancaria = new ContaBancaria(numeroConta, nomeTitular, valorDepositoInicial);

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(contaBancaria);

            //Depósito
            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Depositar(valorDeposito);
            Console.WriteLine(contaBancaria);

            //Saque
            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Sacar(valorSaque);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(contaBancaria);

        }

    }

}
