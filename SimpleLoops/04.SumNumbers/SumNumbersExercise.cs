using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SumNumbers
{
    class SumNumbersExercise
    {
        static void Main(string[] args)
        {
            var numbersCount = int.Parse(
                Console.ReadLine());

            var sum = 0;
            for (var i = 0;
                i < numbersCount;
                i++)
            {
                var number = int.Parse(
                    Console.ReadLine());
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
