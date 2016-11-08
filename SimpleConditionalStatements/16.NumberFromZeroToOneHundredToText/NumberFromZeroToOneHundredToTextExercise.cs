using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.NumberFromZeroToOneHundredToText
{
    class NumberFromZeroToOneHundredToTextExercise
    {
        static void Main(string[] args)
        {
            var number = int.Parse(
                Console.ReadLine());

            if (number < 0 || number > 100)
            {
                Console.WriteLine("invalid number");
            }
            else if (number >= 0 && number < 20)
            {
                switch (number)
                {
                    case 0:
                        Console.WriteLine("zero");
                        break;
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    case 3:
                        Console.WriteLine("three");
                        break;
                    case 4:
                        Console.WriteLine("four");
                        break;
                    case 5:
                        Console.WriteLine("five");
                        break;
                    case 6:
                        Console.WriteLine("six");
                        break;
                    case 7:
                        Console.WriteLine("seven");
                        break;
                    case 8:
                        Console.WriteLine("eight");
                        break;
                    case 9:
                        Console.WriteLine("nine");
                        break;
                    case 10:
                        Console.WriteLine("ten");
                        break;
                    case 11:
                        Console.WriteLine("eleven");
                        break;
                    case 12:
                        Console.WriteLine("twelve");
                        break;
                    case 13:
                        Console.WriteLine("thirteen");
                        break;
                    case 14:
                        Console.WriteLine("fourteen");
                        break;
                    case 15:
                        Console.WriteLine("fifteen");
                        break;
                    case 16:
                        Console.WriteLine("sixteen");
                        break;
                    case 17:
                        Console.WriteLine("seventeen");
                        break;
                    case 18:
                        Console.WriteLine("eighteen");
                        break;
                    case 19:
                        Console.WriteLine("nineteen");
                        break;
                }
            }
            else if (number >= 20 && number < 100)
            {
                var firstWord = "";
                var secondWord = "";

                var remainder = number / 10;
                switch (remainder)
                {
                    case 2:
                        firstWord = "Twenty";
                        break;
                    case 3:
                        firstWord = "Thirty";
                        break;
                    case 4:
                        firstWord = "Fourty";
                        break;
                    case 5:
                        firstWord = "Fifty";
                        break;
                    case 6:
                        firstWord = "Sixty";
                        break;
                    case 7:
                        firstWord = "Seventy";
                        break;
                    case 8:
                        firstWord = "Eighty";
                        break;
                    case 9:
                        firstWord = "Ninety";
                        break;
                }

                var quotient = number % 10;
                switch (quotient)
                {
                    case 1:
                        secondWord = "one";
                        break;
                    case 2:
                        secondWord = "two";
                        break;
                    case 3:
                        secondWord = "three";
                        break;
                    case 4:
                        secondWord = "four";
                        break;
                    case 5:
                        secondWord = "five";
                        break;
                    case 6:
                        secondWord = "six";
                        break;
                    case 7:
                        secondWord = "seven";
                        break;
                    case 8:
                        secondWord = "eight";
                        break;
                    case 9:
                        secondWord = "nine";
                        break;
                }

                var numberName = "";
                if (secondWord == "")
                {
                    numberName = firstWord;
                }
                else
                {
                    numberName = firstWord + " " + secondWord;
                }

                Console.WriteLine(numberName);
            }
            else if (number == 100)
            {
                Console.WriteLine("One Hundred");
            }
        }
    }
}
