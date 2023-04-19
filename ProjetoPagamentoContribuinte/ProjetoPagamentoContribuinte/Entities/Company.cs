using System;
using System.Collections.Generic;

namespace ProjetoPagamentoContribuinte.Entities
{
    internal class Company : Contributor
    {
        public int EmployeeQuantity { get; set; }

        public Company()
        {
        }

        public Company(string name, double anualIncome, int employeeQuantity) : base(name, anualIncome)
        {
            EmployeeQuantity = employeeQuantity;
        }

        public override double Tax()
        {
            if (EmployeeQuantity > 10)
            {
                return AnualIncome * 0.14;
            } 
            else {
                return AnualIncome * 0.16;
            }
        }
        
    }
}
