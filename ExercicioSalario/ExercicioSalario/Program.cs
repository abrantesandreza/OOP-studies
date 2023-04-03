using ExercicioSalario;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Fazer um programa para ler nome e salário de dois funcionários.
            Depois, mostrar o salário médio dos funcionários. */


            //Informações dos funcionários 

            Funcionario funcionarioUm, funcionarioDois;

            funcionarioUm = new Funcionario();
            funcionarioDois = new Funcionario();

            Console.Write("Qual o nome do funcionário? ");
            funcionarioUm.Nome = Console.ReadLine();

            Console.Write("Qual o salario desse funcionário? ");
            funcionarioUm.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Qual o nome do funcionário? ");
            funcionarioDois.Nome = Console.ReadLine();

            Console.Write("Qual o salario desse funcionário? ");
            funcionarioDois.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            //Média dos salários
            double salarioMedio;

            salarioMedio = (funcionarioUm.Salario + funcionarioDois.Salario) / 2;

            Console.WriteLine("Salário médio: " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));

        }

    }

}


