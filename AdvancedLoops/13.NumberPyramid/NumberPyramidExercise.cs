using System;

namespace _13.NumberPyramid
{
    class NumberPyramidExercise
    {
        static void Main(string[] args)
        {
            var maximumNumberToPrint = int.Parse(
                Console.ReadLine());

            var currentNumberToPrint = 1;
            var numbersToPrintCount = 1;
            while (currentNumberToPrint <= maximumNumberToPrint)
            {
                for (var i = 0; 
                    i < numbersToPrintCount;
                    i++)
                {
                    Console.Write("{0} ", 
                        currentNumberToPrint);
                    currentNumberToPrint++;
                    if (currentNumberToPrint > maximumNumberToPrint)
                    {
                        break;
                    }

                }
                numbersToPrintCount++;
                Console.WriteLine();
            }
        }
    }
}
