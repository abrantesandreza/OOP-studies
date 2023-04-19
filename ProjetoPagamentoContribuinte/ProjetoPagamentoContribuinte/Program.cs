using ProjetoPagamentoContribuinte;
using ProjetoPagamentoContribuinte.Entities;
using System;
using System.Globalization;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cria uma lista de Contributor vazia
            List<Contributor> contributoresList = new List<Contributor>();

            Console.WriteLine("Enter the number of tax payers: ");
            int numberOfContributores = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfContributores; i++) {
                
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or Company (i/c)? ");
                char typeOfContributor = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                String name = Console.ReadLine();

                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                //Caso o tipo de contribuinte seja Individual
                if (typeOfContributor == 'i') {
                    Console.Write("Health expenditures: ");
                    double healthExpenses = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    //Instancia Individual e adiciona na lista contributoresList
                    contributoresList.Add(new Individual(name, anualIncome, healthExpenses));
                } 
                else if (typeOfContributor == 'c') {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    //Instancia Company e adiciona na lista contributoresList
                    contributoresList.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            //Calcula os impostos individualmente de cada contribuinte
            foreach (Contributor contributor in contributoresList)
            {
                Console.WriteLine(contributor.Name + ": $" + contributor.Tax().ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.WriteLine();
            //Calcula o total de impostos arrecadados
            double totalTaxes = 0.0;
            foreach (Contributor contributor in contributoresList) {
                totalTaxes += contributor.Tax();
            }
            Console.WriteLine("TOTAL TAXES: " + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
