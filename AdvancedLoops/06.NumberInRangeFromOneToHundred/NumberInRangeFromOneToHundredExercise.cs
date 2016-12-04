using System;

namespace _06.NumberInRangeFromOneToHundred
{
    class NumberInRangeFromOneToHundredExercise
    {
        static void Main(string[] args)
        {
            var number = 0;
            var isInvalidNumber = false;
            do
            {
                Console.Write("Enter a number in the range [1...100]: ");
                number = int.Parse(
                    Console.ReadLine());
                isInvalidNumber = number < 1 ||
                    number > 100;
            }
            while (isInvalidNumber);

            Console.WriteLine("The number is: {0}",
                number);
        }
    }
}
