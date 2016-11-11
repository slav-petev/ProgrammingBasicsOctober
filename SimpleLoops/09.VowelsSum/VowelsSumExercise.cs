using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.VowelsSum
{
    class VowelsSumExercise
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();

            var vowelsSum = 0;
            for (var i = 0;
                i < word.Length;
                i++)
            {
                switch (word[i])
                {
                    case 'a':
                        vowelsSum += 1;
                        break;
                    case 'e':
                        vowelsSum += 2;
                        break;
                    case 'i':
                        vowelsSum += 3;
                        break;
                    case 'o':
                        vowelsSum += 4;
                        break;
                    case 'u':
                        vowelsSum += 5;
                        break;
                }

                Console.WriteLine(vowelsSum);
            }
        }
    }
}
