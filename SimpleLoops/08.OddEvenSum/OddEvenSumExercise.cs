using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.OddEvenSum
{
    class OddEvenSumExercise
    {
        static void Main(string[] args)
        {
            var numbersCount = int.Parse(
                Console.ReadLine());

            var oddSum = 0;
            var evenSum = 0;
            for (var i = 0;
                i < numbersCount;
                i++)
            {
                var currentNumber = int.Parse(
                    Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += currentNumber;
                }
                else
                {
                    oddSum += currentNumber;
                }
            }

            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}",
                    oddSum);
            }
            else
            {
                var sumDifference = Math
                    .Abs(oddSum - evenSum);

                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}",
                    sumDifference);
            }
        }
    }
}
