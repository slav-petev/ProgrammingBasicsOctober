using System;

namespace _05.SquareFrame
{
    class SquareFrameExercise
    {
        static void Main(string[] args)
        {
            var frameSize = int.Parse(
                Console.ReadLine());

            var numberOfDashesPerLine =
                frameSize - 2;

            Console.Write("+ ");
            for (var i = 0;
                i < numberOfDashesPerLine;
                i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");

            var frameBodyHeight =
                frameSize - 2; 
            for (var i = 0;
                i < frameBodyHeight;
                i++)
            {
                Console.Write("| ");
                for (var j = 0;
                j < numberOfDashesPerLine;
                j++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine("|");
            }

            Console.Write("+ ");
            for (var i = 0;
                i < numberOfDashesPerLine;
                i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");
        }
    }
}
