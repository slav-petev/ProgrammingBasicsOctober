using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LeftAndRightSum
{
    class LeftAndRightSumExercise
    {
        static void Main(string[] args)
        {
            var numbersCount = int.Parse(
                Console.ReadLine());

            var leftSum = 0;
            var rightSum = 0;

            for (var currentLeftNumberPosition = 0;
                currentLeftNumberPosition < numbersCount;
                currentLeftNumberPosition++)
            {
                var currentLeftNumber = int.Parse(
                    Console.ReadLine());
                leftSum += currentLeftNumber;
            }

            for (var currentRighttNumberPosition = 0;
                currentRighttNumberPosition < numbersCount;
                currentRighttNumberPosition++)
            {
                var currentRightNumber = int.Parse(
                    Console.ReadLine());
                rightSum += currentRightNumber;
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = {0}",
                    leftSum);
            }
            else
            {
                var sumDifference = Math
                    .Abs(leftSum - rightSum);

                Console.WriteLine("No, diff = {0}",
                    sumDifference);
            }
        }
    }
}
