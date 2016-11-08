using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LatinLetters
{
    class LatinLettersExercise
    {
        static void Main(string[] args)
        {
            for (var currentLetter = 'a';
                currentLetter <= 'z';
                currentLetter++)
            {
                Console.WriteLine(currentLetter);
            }
        }
    }
}
