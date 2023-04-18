
namespace ExercicioParams
{
    internal class Calculator
    {

        public static int Sum(params int[] numbers)
        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }

            return result;
        }

    }

}
