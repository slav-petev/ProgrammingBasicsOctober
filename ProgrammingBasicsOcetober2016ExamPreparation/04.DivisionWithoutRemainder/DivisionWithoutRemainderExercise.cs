using System;

namespace _04.DivisionWithoutRemainder
{
    class DivisionWithoutRemainderExercise
    {
        static void Main(string[] args)
        {
            var numbersCount = int.Parse(
                Console.ReadLine());

            var numbersDivisibleByTwo = 0.0;
            var numbersDivisibleByThree = 0.0;
            var numbersDivisibleByFour = 0.0;

            for (var i = 0;
                i < numbersCount;
                i++)
            {
                var currentNumber = int.Parse(
                    Console.ReadLine());
                if (currentNumber % 2 == 0)
                {
                    numbersDivisibleByTwo++;
                }
                if (currentNumber % 3 == 0)
                {
                    numbersDivisibleByThree++;
                }
                if (currentNumber % 4 == 0)
                {
                    numbersDivisibleByFour++;
                }
            }

            var numbersDivisibleByTwoPercent =
                (numbersDivisibleByTwo / numbersCount) *
                100;
            Console.WriteLine("{0:F2}%",
                numbersDivisibleByTwoPercent);
            var numbersDivisibleByThreePercent =
                (numbersDivisibleByThree / numbersCount) *
                100;
            Console.WriteLine("{0:F2}%",
                numbersDivisibleByThreePercent);
            var numbersDivisibleByFourPercent =
                (numbersDivisibleByFour / numbersCount) *
                100;
            Console.WriteLine("{0:F2}%",
                numbersDivisibleByFourPercent);
        }
    }
}
