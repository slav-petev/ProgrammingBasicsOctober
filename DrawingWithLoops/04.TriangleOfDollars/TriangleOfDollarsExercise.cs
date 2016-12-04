using System;

namespace _04.TriangleOfDollars
{
    class TriangleOfDollarsExercise
    {
        static void Main(string[] args)
        {
            var triangleSize = int.Parse(
                Console.ReadLine());
            
            for (var i = 1;
                i <= triangleSize;
                i++)
            {
                for (var j = 1;
                    j <= i;
                    j++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }
        }
    }
}
