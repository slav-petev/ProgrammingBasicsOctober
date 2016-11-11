using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MinNumber
{
    class MinNumberExercise
    {
        static void Main(string[] args)
        {
            var numbersCount = int.Parse(
                Console.ReadLine());

            var minNumber = int.MaxValue;
            for (var i = 0;
                i < numbersCount;
                i++)
            {
                var currentNumber = int.Parse(
                    Console.ReadLine()); ;
                minNumber = Math.Min(currentNumber,
                    minNumber);
            }

            Console.WriteLine(minNumber);
        }
    }
}
