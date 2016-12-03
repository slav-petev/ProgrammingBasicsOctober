using System;

namespace _05.DrawFort
{
    class DrawFortExercise
    {
        static void Main(string[] args)
        {
            var fortSize = int.Parse(
                Console.ReadLine());
            var numberOfSymbolsPerSide = fortSize;

            var numberOfSlashesPerSideInTop = 2;
            var numberOfHousesPerSideInTop =
                numberOfSymbolsPerSide / 2;
            var numberOfUnderscoresPerSideInTop =
                numberOfSymbolsPerSide -
                (numberOfHousesPerSideInTop +
                numberOfSlashesPerSideInTop);

            Console.WriteLine(@"/{0}\{1}{1}/{0}\",
                new string('^', numberOfHousesPerSideInTop),
                new string('_', numberOfUnderscoresPerSideInTop));

            var fortBodyHeight = fortSize - 3;
            var numberOfWhitespacesPerSideInBody =
                numberOfSymbolsPerSide - 1;
            for (var i = 0;
                i < fortBodyHeight;
                i++)
            {
                Console.WriteLine("|{0}{0}|",
                    new string(' ', 
                    numberOfWhitespacesPerSideInBody));
            }

            var numberOfPipesPerSideInBottomBodyFortRow = 
                1;
            var numberOfUnderscoresPerSideInBottomBodyFortRow =
                numberOfUnderscoresPerSideInTop;
            var numberOfWhitespacesPerSideInBottomBodyFortRow =
                numberOfSymbolsPerSide -
                (numberOfUnderscoresPerSideInBottomBodyFortRow +
                numberOfPipesPerSideInBottomBodyFortRow);
            Console.WriteLine("|{0}{1}{1}{0}|",
                new string(' ', 
                numberOfWhitespacesPerSideInBottomBodyFortRow),
                new string('_', 
                numberOfUnderscoresPerSideInBottomBodyFortRow));

            var numberOfSlashesPerSideInBase =
                numberOfSlashesPerSideInTop;
            var numberOfUnderscoresPerSideInBase =
                numberOfHousesPerSideInTop;
            var numberOfWhitespacesPerSideInBase =
                numberOfUnderscoresPerSideInTop;
            Console.WriteLine(@"\{0}/{1}{1}\{0}/",
                new string('_',
                numberOfUnderscoresPerSideInBase),
                new string(' ', numberOfWhitespacesPerSideInBase));
        }
    }
}
