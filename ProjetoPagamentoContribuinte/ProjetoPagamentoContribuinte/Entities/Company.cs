using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            double defaultCompanyTax = (AnualIncome * 16.0) / 100;
            if (EmployeeQuantity > 10)
            {
                return (AnualIncome * 14.0) / 100;
            }
            return defaultCompanyTax;
        }

    }
}
