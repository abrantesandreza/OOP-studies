using ExercicioFuncionario;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite, abaixo, as três notas do aluno");
            Console.Write("Primeiro Trimestre: ");
            aluno.NotaPrimeiroTri = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Segundo Trimestre: ");
            aluno.NotaSegundoTri = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Terceiro Trimestre: ");
            aluno.NotaTerceiroTri = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(aluno.AprovadoOuReprovado());

        }

    }

}
