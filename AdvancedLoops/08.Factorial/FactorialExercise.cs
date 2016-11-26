using System;

namespace _08.Factorial
{
    class FactorialExercise
    {
        static void Main(string[] args)
        {
            var number = int.Parse(
                Console.ReadLine());

            var result = 1;

            for (var i = 2;
                i <= number;
                i++)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }
}
