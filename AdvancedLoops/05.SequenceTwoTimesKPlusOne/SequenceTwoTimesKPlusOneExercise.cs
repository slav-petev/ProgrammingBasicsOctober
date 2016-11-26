using System;

namespace _05.SequenceTwoTimesKPlusOne
{
    class SequenceTwoTimesKPlusOneExercise
    {
        static void Main(string[] args)
        {
            var sequenceUpperBound = int.Parse(
                Console.ReadLine());

            var currentNumber = 1;
            while (currentNumber <= sequenceUpperBound)
            {
                Console.WriteLine(currentNumber);
                currentNumber = currentNumber * 2
                    + 1;
            }
        }
    }
}
