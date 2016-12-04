using System;

namespace _02.RectangleOfNPerNStars
{
    class RectangleOfNPerNStarsExercise
    {
        static void Main(string[] args)
        {
            var rectangleSize = int.Parse(
                Console.ReadLine());

            for (var i = 0;
                i < rectangleSize;
                i++)
            {
                Console.WriteLine(
                    new string('*', rectangleSize));
            }
        }
    }
}
