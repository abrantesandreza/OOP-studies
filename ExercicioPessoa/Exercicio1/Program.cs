using Exercicio1;
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Faça um programa para ler os dados de duas pessoas, depois mostrar
             * o nome da pessoa mais velha. */

            Pessoa pessoaUm, pessoaDois;

            pessoaUm = new Pessoa();
            pessoaDois = new Pessoa();

            Console.Write("Escreva o nome da primeira pessoa: ");
            pessoaUm.Nome = Console.ReadLine();
            Console.Write("Qual a idade dessa pessoa? ");
            pessoaUm.Idade = int.Parse(Console.ReadLine());

            Console.Write("Escreva o nome da segunda pessoa: ");
            pessoaDois.Nome = Console.ReadLine();
            Console.Write("Qual a idade dessa pessoa? ");
            pessoaDois.Idade = int.Parse(Console.ReadLine());


            if (pessoaUm.Idade > pessoaDois.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + pessoaUm.Nome);
            } else
            {
                Console.WriteLine("Pessoa mais velha: " + pessoaDois.Nome);
            }

        }

    }

}




