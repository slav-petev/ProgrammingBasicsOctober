using System;

namespace _04.EvenPowersOfTwo
{
    class EvenPowersOfTwoExercise
    {
        static void Main(string[] args)
        {
            var number = int.Parse(
                Console.ReadLine());

            var result = 1;

            for (var i = 0;
                i <= number;
                i += 2)
            {
                Console.WriteLine(result);
                result *= 4;
            }
        }
    }
}
