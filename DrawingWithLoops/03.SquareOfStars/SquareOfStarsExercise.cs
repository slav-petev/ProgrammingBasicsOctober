using System;

namespace _03.SquareOfStars
{
    class SquareOfStarsExercise
    {
        static void Main(string[] args)
        {
            var squareSize = int.Parse(
                Console.ReadLine());

            for (var i = 0;
                i < squareSize;
                i++)
            {
                for (var j = 0;
                    j < squareSize;
                    j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
