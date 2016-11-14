using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.HalfSumElement
{
    class HalfSumElementExercise
    {
        static void Main(string[] args)
        {
            var numbersCount = int.Parse(
                Console.ReadLine());

            var maxNumber = int.MinValue;
            var sumElements = 0;

            for (var i = 0;
                i < numbersCount;
                i++)
            {
                var currentNumber = int.Parse(
                    Console.ReadLine());
                if (currentNumber > maxNumber)
                {
                    maxNumber = currentNumber;
                }
                sumElements += currentNumber;
            }

            var sumElementsWithoutMaxNumber = sumElements -
                maxNumber;
            if (maxNumber == sumElementsWithoutMaxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}",
                    sumElementsWithoutMaxNumber);
            }
            else
            {
                var difference = Math
                    .Abs(maxNumber - sumElementsWithoutMaxNumber);

                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}",
                    difference);
            }
        }
    }
}
