using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MaxNumber
{
    class MaxNumberExercise
    {
        static void Main(string[] args)
        {
            var numbersCount = int.Parse(
                Console.ReadLine());

            var maxNumber = int.MinValue;
            for (var i = 0;
                i < numbersCount;
                i++)
            {
                var currentNumber = int.Parse(
                    Console.ReadLine());
                maxNumber = Math.Max(currentNumber,
                    maxNumber);
            }

            Console.WriteLine(maxNumber);
        }
    }
}
