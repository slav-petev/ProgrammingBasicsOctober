using System;

namespace _01.RectangleOfTenPerTenStars
{
    class RectangleOfTenPerTenStarsExercise
    {
        static void Main(string[] args)
        {
            for (var i = 0;
                i < 10;
                i++)
            {
                Console.WriteLine(
                    new string('*', 10));
            }
        }
    }
}
