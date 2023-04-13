using System;
using System.Globalization;
using System.Collections.Generic;
using ExercicioSalarioEmpresa;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("How many employees will be registered? ");
            int qntdEmployee = int.Parse(Console.ReadLine());

            //Cria uma lista vazia para receber as informações dos funcionários
            List<Employee> employeeList = new List<Employee>();

            for (int i = 1; i <= qntdEmployee; i++)
            {
                Console.WriteLine("Employee #" + i);
                Console.Write("Id: ");
                int idEmployee = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string nameEmployee = Console.ReadLine();

                Console.Write("Salary: ");
                double salaryEmployee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Instancia a classe Employee no método .Add
                employeeList.Add(new Employee(idEmployee, nameEmployee, salaryEmployee));
                Console.WriteLine();

            }

            Console.Write("Enter the employee Id that will have salary increase: ");
            int selectedIdEmployee = int.Parse(Console.ReadLine());
            
            Console.WriteLine();

            Employee employee = employeeList.Find(x => x.Id == selectedIdEmployee);

            //Verifica se o Id é existente
            if (employee != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employee.SalaryIncrease(percentage);
            } else
            {
                Console.WriteLine("This Id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Upated list of employees:");
            //Itera pela lista populada de funcionários
            foreach (Employee employees in employeeList)
            {
                Console.WriteLine(employees);
            }

        }

    }

}
