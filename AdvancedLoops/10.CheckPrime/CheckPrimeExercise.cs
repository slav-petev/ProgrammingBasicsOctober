using System;

namespace _10.CheckPrime
{
    class CheckPrimeExercise
    {
        static void Main(string[] args)
        {
            var number = int.Parse(
                Console.ReadLine());

            var isPrime = true;
            if (number < 2)
            {
                isPrime = false;
            }
            else
            {
                var upperBoundaryToCheck =
               (int)Math.Sqrt(number);

                for (var i = 2;
                    i <= upperBoundaryToCheck;
                    i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }   
            }

            if (isPrime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }

        }
    }
}
