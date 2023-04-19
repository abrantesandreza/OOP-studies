using System;
using System.Collections.Generic;

namespace ProjetoPagamentoContribuinte.Entities
{
    abstract class Contributor
    {

        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public Contributor() 
        {
        }

        protected Contributor(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();

    }
}
