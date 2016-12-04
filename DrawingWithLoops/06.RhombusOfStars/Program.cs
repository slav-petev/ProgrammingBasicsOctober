using System;

namespace _06.RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var rhombusSize = int.Parse(
                Console.ReadLine());

            var numberOfSymbolsPerRow = rhombusSize;

            var numberOfStarsInUpperPart = 1;
            var numberOfWhitespacesInUpperPart =
                numberOfSymbolsPerRow -
                numberOfStarsInUpperPart;

            var upperPartHeight = rhombusSize;
            for (var i = 0;
                i < upperPartHeight;
                i++)
            {
                var whitespaces = new string(' ',
                    numberOfWhitespacesInUpperPart);
                Console.Write(whitespaces);
                for (var j = 0;
                    j < numberOfStarsInUpperPart;
                    j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

                numberOfStarsInUpperPart++;
                numberOfWhitespacesInUpperPart--;
            }

            var numberOfStarsInLowerPart = 
                rhombusSize - 1;
            var numberOfWhitespacesInLowerPart =
                numberOfSymbolsPerRow -
                numberOfStarsInLowerPart;

            var lowerPartHeight = 
                rhombusSize - 1;
            for (var i = 0;
                i < lowerPartHeight;
                i++)
            {
                var whitespaces =
                    new string(' ',
                        numberOfWhitespacesInLowerPart);
                Console.Write(whitespaces);
                for (var j = 0;
                    j < numberOfStarsInLowerPart;
                    j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

                numberOfStarsInLowerPart--;
                numberOfWhitespacesInLowerPart++;
            }
        }
    }
}
