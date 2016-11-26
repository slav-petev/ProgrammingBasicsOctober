using System;

namespace _12.Fibonacci
{
    class FibonacciExercise
    {
        static void Main(string[] args)
        {
            var fibonacciNumberPosition =
                int.Parse(Console.ReadLine());

            switch (fibonacciNumberPosition)
            {
                case 0:
                case 1:
                    Console.WriteLine(1);
                    break;
                default:
                    var firstFibonacciNumber = 1;
                    var secondFibonacciNumber = 1;
                    var nextFibonacciNumber = 0;
                    for (var i = 2; 
                        i <= fibonacciNumberPosition;
                        i++)
                    {
                        nextFibonacciNumber =
                            firstFibonacciNumber +
                            secondFibonacciNumber;

                        firstFibonacciNumber =
                            secondFibonacciNumber;
                        secondFibonacciNumber =
                            nextFibonacciNumber;
                    }
                    Console.WriteLine(nextFibonacciNumber);
                    break;
            }
        }
    }
}
