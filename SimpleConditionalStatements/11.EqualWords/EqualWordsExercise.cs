using System;

namespace _11.EqualWords
{
    class EqualWordsExercise
    {
        static void Main(string[] args)
        {
            var firstWord = Console.ReadLine()
                .ToLower();
            var secondWord = Console.ReadLine()
                .ToLower();

            if (firstWord == secondWord)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
