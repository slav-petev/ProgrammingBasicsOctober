using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.OddEvenPosition
{
    class OddEvenPositionExercise
    {
        static void Main(string[] args)
        {
            var numbersCount = int.Parse(
                Console.ReadLine());

            var oddSumOutputString = "OddSum=";
            var oddMinOutputString = "OddMin=";
            var oddMaxOutputString = "OddMax=";

            var evenSumOutputString = "EvenSum=";
            var evenMinOutputString = "EvenMin=";
            var evenMaxOutputString = "EvenMax=";


            var sumOfNumbersAtOddPositions = 0.0;
            var oddMinOutput = "No";
            var oddMaxOutput = "No";
            
            var sumOfNumbersAtEvenPosition = 0.0;
            var evenMinOutput = "No";
            var evenMaxOutput = "No";

            if (numbersCount == 1)
            {
                var number = double.Parse(
                    Console.ReadLine());

                sumOfNumbersAtOddPositions +=
                    number;
                evenMinOutput = number
                    .ToString();
                evenMaxOutput = number
                    .ToString();
            }
            else
            {
                var oddMin = double.MaxValue;
                var oddMax = double.MinValue;

                var evenMin = double.MaxValue;
                var evenMax = double.MinValue;

                for (var currentPosition = 1;
                    currentPosition <= numbersCount;
                    currentPosition++)
                {
                    var currentNumber = double.Parse(
                        Console.ReadLine());

                    if (currentPosition % 2 == 1)
                    {
                        sumOfNumbersAtOddPositions += 
                            currentNumber;
                        oddMin = Math.Min(oddMin, currentNumber);
                        oddMax = Math.Max(oddMax, currentNumber);
                    }
                    else
                    {
                        sumOfNumbersAtEvenPosition += 
                            currentNumber;
                        evenMin = Math.Min(evenMin, currentNumber);
                        evenMax = Math.Max(evenMax, currentNumber);
                    }
                }
                oddMinOutput = oddMin
                    .ToString();
                oddMaxOutput = oddMax
                    .ToString();

                evenMinOutput = evenMin
                    .ToString();
                evenMaxOutput = evenMax
                    .ToString();
            }

            Console.WriteLine("{0}{1}",
                oddSumOutputString,
                sumOfNumbersAtOddPositions);
            Console.WriteLine("{0}{1}",
                oddMinOutputString,
                oddMinOutput);
            Console.WriteLine("{0}{1}",
                oddMaxOutputString,
                oddMaxOutput);
            Console.WriteLine("{0}{1}",
                evenSumOutputString,
                sumOfNumbersAtEvenPosition);
            Console.WriteLine("{0}{1}",
                evenMinOutputString,
                evenMinOutput);
            Console.WriteLine("{0}{1}",
                evenMaxOutputString,
                evenMaxOutput);
        }
    }
}

