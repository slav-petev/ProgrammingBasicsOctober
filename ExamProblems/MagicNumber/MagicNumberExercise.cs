using System;

namespace MagicNumber
{
    class MagicNumberExercise
    {
        //Link to the problem: https://judge.softuni.bg/Contests/Practice/Index/179#5
        static void Main(string[] args)
        {
            var magicNumber = int.Parse(
                Console.ReadLine());

            for (var number = 100000;
                number <= 999999;
                number++)
            {
                var currentNumber = number;
                var digitsProduct = 1;
                while (currentNumber > 0)
                {
                    var lastDigit =
                        currentNumber % 10;
                    digitsProduct *= lastDigit;
                    currentNumber /= 10;
                }

                if (digitsProduct == magicNumber)
                {
                    Console.Write("{0} ",
                        number);
                }
            }
        }
    }
}
