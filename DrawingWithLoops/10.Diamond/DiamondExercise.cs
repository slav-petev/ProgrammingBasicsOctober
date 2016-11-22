using System;

namespace _10.Diamond
{
    class DiamondExercise
    {
        static void Main(string[] args)
        {
            var diamondSize = int.Parse(
                Console.ReadLine());
            var numberOfSymbolsPerLine =
                diamondSize;

            var numberOfStarsInTop = 0;
            if (diamondSize % 2 == 0)
            {
                numberOfStarsInTop = 2;
            }
            else
            {
                numberOfStarsInTop = 1;
            }
            var numberOfDashesPerSideInTop =
                (numberOfSymbolsPerLine -
                 numberOfStarsInTop) / 2;

            Console.WriteLine("{0}{1}{0}",
                new string('-', numberOfDashesPerSideInTop),
                new string('*', numberOfStarsInTop));


            var numberOfDashesBetweenStarsInUpperBody = 0;
            if (diamondSize % 2 == 0)
            {
                numberOfDashesBetweenStarsInUpperBody = 2;
            }
            else
            {
                numberOfDashesBetweenStarsInUpperBody = 1;
            }

            var numberOfDashesPerSideInUpperBody = 0;
            if (diamondSize % 2 == 0)
            {
                numberOfDashesPerSideInUpperBody =
                    diamondSize / 2 - 2;
            }
            else
            {
                numberOfDashesPerSideInUpperBody =
                    diamondSize / 2 - 1;
            }

            var upperBodyHeight = 0;
            if (diamondSize % 2 == 0)
            {
                upperBodyHeight =
                    diamondSize / 2 - 2;
            }
            else
            {
                upperBodyHeight =
                    diamondSize / 2 - 1;
            }

            for (var i = 0;
                i <= upperBodyHeight;
                i++)
            {
                Console.WriteLine("{0}*{1}*{0}",
                    new string('-', numberOfDashesPerSideInUpperBody),
                    new string('-', numberOfDashesBetweenStarsInUpperBody));

                numberOfDashesPerSideInUpperBody--;
                numberOfDashesBetweenStarsInUpperBody += 2;
            }

            var numberOfDashesPerSideInLowerBody = 1;
            var numberOfDashesBetweenStarsInLowerBody =
                diamondSize - 4;
            var lowerBodyHeight = upperBodyHeight;
            for (var i = 0;
                i < lowerBodyHeight;
                i++)
            {
                Console.WriteLine("{0}*{1}*{0}",
                    new string('-', numberOfDashesPerSideInLowerBody),
                    new string('-', numberOfDashesBetweenStarsInLowerBody));

                numberOfDashesPerSideInLowerBody++;
                numberOfDashesBetweenStarsInLowerBody =
                    numberOfDashesBetweenStarsInLowerBody - 2;
            }

            if (diamondSize > 2)
            {
                var numberOfStarsInBase =
                    numberOfStarsInTop;
                var numberOfDashesPerSideInBase =
                    numberOfDashesPerSideInTop;

                Console.WriteLine("{0}{1}{0}",
                    new string('-', numberOfDashesPerSideInBase),
                    new string('*', numberOfStarsInBase));
            }
        }
    }
}
