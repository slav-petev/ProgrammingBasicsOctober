using System;

namespace _09.SumDigits
{
    class SumDigitsExercise
    {
        static void Main(string[] args)
        {
            var number = int.Parse(
                Console.ReadLine());

            var digitsSum = 0;
            while (number > 0)
            {
                var lastDigit =
                    number % 10;
                digitsSum +=
                    lastDigit;
                number /= 10;
            }

            Console.WriteLine(digitsSum);
        }
    }
}
