using ExercicioFuncionario;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario funcionario = new Funcionario();

            Console.WriteLine("Entre com os dados do funcionário abaixo:");
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Chama o método SalarioLiquido
            double salarioLiq = funcionario.SalarioLiquido();

            Console.WriteLine(funcionario + salarioLiq.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double aumentoSalarial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Atualiza o salário com base no método AumentarSalario
            double novoSalario = funcionario.AumentarSalario(aumentoSalarial);

            Console.WriteLine();
            Console.WriteLine(funcionario + novoSalario.ToString("F2", CultureInfo.InvariantCulture));

        }

    }

}
