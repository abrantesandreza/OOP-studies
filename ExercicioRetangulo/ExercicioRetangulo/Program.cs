
using ExercicioRetangulo;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            Console.Write("Largura: ");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Altura: ");
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaRetangulo = retangulo.Area();
            double perimetroRetangulo = retangulo.Perimetro();
            double diagonalRetangulo = retangulo.Diagonal();

            Console.WriteLine();
            Console.WriteLine("AREA = " + areaRetangulo.ToString("F2", CultureInfo.InvariantCulture) + " m²");
            Console.WriteLine("PERÍMETRO = " + perimetroRetangulo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonalRetangulo.ToString("F2", CultureInfo.InvariantCulture));

        }

    }

}
