namespace ExercicioCalculadoraDolar
{
    class ConversorDeMoeda
    {

        public double Cotacao;
                
        //Cálculos da conversão
        public double ConverterDolarReal(double quantidadeDolar)
        {
            return Cotacao * quantidadeDolar;
        }

        public double ImpostoIOF(double quantidadeDolar)
        {
            double porcentImposto = (6.00 / 100.0) * ConverterDolarReal(quantidadeDolar);
            double valorImposto = porcentImposto + ConverterDolarReal(quantidadeDolar);
            return valorImposto;
        }

    }
}
