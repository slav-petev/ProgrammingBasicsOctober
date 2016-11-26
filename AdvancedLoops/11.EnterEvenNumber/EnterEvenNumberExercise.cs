using System;

namespace _11.EnterEvenNumber
{
    class EnterEvenNumberExercise
    {
        static void Main(string[] args)
        {
            var number = 0;
            var isInvalidNumber = false;
            do
            {
                try
                {
                    isInvalidNumber = false;
                    Console.Write("Enter even number: ");
                    number = int.Parse(
                        Console.ReadLine());

                    if (Math.Abs(number % 2) == 1)
                    {
                        Console.WriteLine("The number is not even");
                        isInvalidNumber = true;
                    }
                }
                catch (Exception)
                {
                    isInvalidNumber = true;
                    Console.WriteLine("Invalid number!");
                }
            }
            while (isInvalidNumber);

            Console.WriteLine("Even number entered: {0}",
                number);
        }
    }
}
