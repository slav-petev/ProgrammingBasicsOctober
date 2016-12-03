using System;

namespace _06.SpecialNumbers
{
    class SpecialNumbersExercise
    {
        static void Main(string[] args)
        {
            var number = int.Parse(
                Console.ReadLine());
            
            for (var i = 1111;
                i <= 9999;
                i++)
            {
                var currentNumber = i;
                var isSpecial = true;
                while (currentNumber > 0)
                {
                    var lastDigit = currentNumber %
                        10;
                    if (lastDigit == 0)
                    {
                        isSpecial = false;
                        break;
                    }
                    if (number % lastDigit != 0)
                    {
                        isSpecial = false;
                        break;
                    }
                    currentNumber /= 10;
                }

                if (isSpecial)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}
