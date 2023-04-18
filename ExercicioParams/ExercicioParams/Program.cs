using ExercicioParams;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            int result = Calculator.Sum(10, 20, 30, 40);
            int result2 = Calculator.Sum(20, 5, 30, 10, 5);

            Console.WriteLine(result);
            Console.WriteLine(result2);

        }

    }

}