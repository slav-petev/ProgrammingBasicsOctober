using System;

namespace _01.PersonalTitles
{
    class PersonalTitlesExcercise
    {
        static void Main(string[] args)
        {
            var age = double.Parse(
                Console.ReadLine());
            var gender = char.Parse(
                Console.ReadLine());

            var isMale = gender == 'm';
            var isFemale = gender == 'f';
            var isYoungerThanSixteen = age < 16;

            if (isMale)
            {
                if (isYoungerThanSixteen)
                {
                    Console.WriteLine("Master");
                }
                else
                {
                    Console.WriteLine("Mr.");
                }
            }
            else if (isFemale)
            {
                if (isYoungerThanSixteen)
                {
                    Console.WriteLine("Miss");
                }
                else
                {
                    Console.WriteLine("Ms.");
                }
            }

        }
    }
}
