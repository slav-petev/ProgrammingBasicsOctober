using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.GreaterNumber
{
    class GreaterNumberExercise
    {
        static void Main(string[] args)
        {
            var firstNumber = double.Parse(
                Console.ReadLine());
            var secondNumber = double.Parse(
                Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine(firstNumber);
            }
            else
            {
                Console.WriteLine(secondNumber);
            }
        }
    }
}
