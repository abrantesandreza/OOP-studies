using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioSalarioEmpresa
{
    internal class Employee
    {

        public int Id { get; private set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee(int idEmployee, string nameEmployee, double salaryEmployee)
        {
            Id = idEmployee;
            Name = nameEmployee;
            Salary = salaryEmployee;
        }

        public void SalaryIncrease(double increasePercentage)
        {
            Salary += Salary * increasePercentage / 100.0;

        }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

    }

}
