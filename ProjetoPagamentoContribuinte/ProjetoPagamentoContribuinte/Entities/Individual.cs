using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPagamentoContribuinte.Entities
{
    internal class Individual : Contributor
    {
        public double HealthExpenditures { get; set; }

        public Individual() 
        {
        }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (AnualIncome < 20000.00)
            {
                return (AnualIncome * 15.0) / 100;
            }
            else if (AnualIncome > 20000.00)
            {
                return (AnualIncome * 25.0) / 100;
            }
        }

        public double HealthTax()
        {
            double healthDiscount = HealthExpenditures / 2.0;
            return Tax() - healthDiscount;
        }

    }
}
