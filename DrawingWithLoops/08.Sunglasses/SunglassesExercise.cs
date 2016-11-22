using System;

namespace _08.Sunglasses
{
    class SunglassesExercise
    {
        static void Main(string[] args)
        {
            var sunglassesSize = int.Parse(
                Console.ReadLine());

            var numberOfStarsPerSideInTop =
                2 * sunglassesSize;
            Console.WriteLine("{0}{1}{0}",
                new string('*', numberOfStarsPerSideInTop),
                new string(' ', sunglassesSize));

            var middleRowNumber = 0;
            if (sunglassesSize % 2 == 0)
            {
                middleRowNumber =
                    sunglassesSize / 2 - 1;
            }
            else
            {
                middleRowNumber =
                    sunglassesSize / 2;
            }
            var numberOfSymbolsBetweenStarsInBody =
                2 * sunglassesSize - 2;
            for (var i = 0;
                i < sunglassesSize - 2;
                i++)
            {
                var joiningSymbol = '\0';
                if (i == middleRowNumber - 1)
                {
                    joiningSymbol = '|';
                }
                else
                {
                    joiningSymbol = ' ';
                }

                Console.WriteLine("*{0}*{1}*{0}*",
                    new string('/', numberOfSymbolsBetweenStarsInBody),
                    new string(joiningSymbol, sunglassesSize));
            }

            var numberOfStarsPerSideInBottom =
                numberOfStarsPerSideInTop;
            Console.WriteLine("{0}{1}{0}",
                new string('*', numberOfStarsPerSideInBottom),
                new string(' ', sunglassesSize));
        }
    }
}
