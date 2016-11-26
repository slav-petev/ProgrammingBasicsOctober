using System;

namespace _03.PowersOfTwo
{
    class PowersOfTwoExercise
    {
        static void Main(string[] args)
        {
            var number = int.Parse(
                Console.ReadLine());

            var result = 1;

            for (var i = 0;
                i <= number;
                i++)
            {
                Console.WriteLine(result);
                result *= 2;
            }
        }
    }
}
