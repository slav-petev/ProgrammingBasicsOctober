using System;

namespace _07.GreatestCommonDivisor
{
    class GreatestCommonDivisorExercise
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(
                Console.ReadLine());
            var secondNumber = int.Parse(
                Console.ReadLine());

            while (secondNumber > 0)
            {
                var temp = secondNumber;
                secondNumber = firstNumber %
                    secondNumber;
                firstNumber = temp;
            }

            Console.WriteLine(firstNumber);
        }
    }
}
