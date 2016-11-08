using System;

namespace _13.AreaOfFigures
{
    class AreaOfFiguresExercise
    {
        static void Main(string[] args)
        {
            var figureType = Console.ReadLine();

            var figureArea = 0.0;

            if (figureType == "square")
            {
                var side = double.Parse(
                    Console.ReadLine());

                figureArea = side * side;
            }
            else if (figureType == "rectangle")
            {
                var firstSide = double.Parse(
                    Console.ReadLine());
                var secondSide = double.Parse(
                    Console.ReadLine());

                figureArea = firstSide * 
                    secondSide;
            }
            else if (figureType == "circle")
            {
                var radius = double.Parse(
                    Console.ReadLine());

                figureArea = Math.PI *
                    radius * radius;
            }
            else if (figureType == "triangle")
            {
                var side = double.Parse(
                    Console.ReadLine());
                var height = double.Parse(
                    Console.ReadLine());

                figureArea = side * height / 2;

            }

            Console.WriteLine("{0:F3}",
                figureArea);
        }
    }
}
