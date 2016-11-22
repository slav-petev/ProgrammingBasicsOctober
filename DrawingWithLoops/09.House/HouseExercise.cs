using System;

namespace _09.House
{
    class HouseExercise
    {
        static void Main(string[] args)
        {
            var houseSize = int.Parse(
                Console.ReadLine());

            var numberOfSymbolsPerRowInRoof =
                houseSize;
            var numberOfStarsInRoof = 0;
            if (houseSize % 2 == 0)
            {
                numberOfStarsInRoof = 2;
            }
            else
            {
                numberOfStarsInRoof = 1;
            }
            var numberOfDashesPerSideInRoof =
                (numberOfSymbolsPerRowInRoof -
                numberOfStarsInRoof) / 2;
            var roofHeight = 0;
            if (houseSize % 2 == 0)
            {
                roofHeight = houseSize / 2;
            }
            else
            {
                roofHeight = houseSize / 2 + 1;
            }

            for (var i = 0;
                i < roofHeight;
                i++)
            {
                Console.WriteLine("{0}{1}{0}",
                    new string('-', numberOfDashesPerSideInRoof),
                    new string('*', numberOfStarsInRoof));

                numberOfDashesPerSideInRoof--;
                numberOfStarsInRoof += 2;
            }

            var numberOfSymbolsInBase =
                houseSize;
            var numberOfPipesInBase = 2;
            var numberOfStarsInBase =
                numberOfSymbolsInBase -
                numberOfPipesInBase;
            var baseHeight = houseSize / 2;

            for (var i = 0;
                i < baseHeight;
                i++)
            {
                Console.WriteLine("|{0}|",
                    new string('*', numberOfStarsInBase));
            }
        }
    }
}
