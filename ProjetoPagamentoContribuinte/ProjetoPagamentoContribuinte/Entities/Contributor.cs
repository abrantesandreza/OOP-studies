using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPagamentoContribuinte.Entities
{
    abstract class Contributor
    {

        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public Contributor() 
        {
        }

        public Contributor(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();

    }
}
