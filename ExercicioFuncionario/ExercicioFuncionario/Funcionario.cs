using System.Globalization;

namespace ExercicioFuncionario
{
    class Funcionario
    {

        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        //Cálculos do salário
        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public double AumentarSalario(double aumentoSalario)
        {
            double novoValor = SalarioBruto * (aumentoSalario / 100);
            return novoValor += SalarioLiquido();
        }

        public override string ToString()
        {
            return "Funcionário: " + Nome + " | $";
        }

    }
}

