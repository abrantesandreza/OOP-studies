using ExercicioCalculadoraDolar;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            ConversorDeMoeda conversor = new ConversorDeMoeda();

            Console.Write("Qual a cotação do dólar: ");
            conversor.Cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double dolarAComprar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Chama o método com o cálculo final
            double valorFinalComIOF = conversor.ImpostoIOF(dolarAComprar); 

            Console.WriteLine("Valor a ser pago em reais: " + valorFinalComIOF.ToString("F2", CultureInfo.InvariantCulture));

        }

    }

}
