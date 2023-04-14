using System;
using ExercicioCompany.Entities;
using ExercicioCompany.Entities.Enums;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the department's name: ");
            string departName = Console.ReadLine();

            Console.WriteLine("Enter employee data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            //Utiliza o enum para especificar o tipo de contrato
            EmployeeLevel level = Enum.Parse<EmployeeLevel>(Console.ReadLine());

            Console.Write("Base salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Instancia Department e Employee já passando seus respectivos parâmetros
            Department department = new Department(departName);
            Employee employeeInfo = new Employee(name, level, salary, department);

            Console.Write("How many contracts does this employee have? ");
            int qntContract = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= qntContract; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YY): ");
                DateTime contractDate = DateTime.Parse(Console.ReadLine());
                
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                //Instancia HourContract já passando seus parâmetros
                HourContract contract = new HourContract(contractDate, valuePerHour, hours);
                //E chama o método AddContract para adicionar todas as informações a contract
                employeeInfo.AddContract(contract);
            }

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            //Divide a string monthAndYear para guardar as informações de mês e ano separadamente
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: " + employeeInfo.Name);
            Console.WriteLine("Department: " + department.Name);
            Console.WriteLine($"Income for {monthAndYear}: " + employeeInfo.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
