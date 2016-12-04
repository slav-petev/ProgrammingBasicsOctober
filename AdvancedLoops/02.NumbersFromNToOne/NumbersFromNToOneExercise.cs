using System;

namespace _02.NumbersFromNToOne
{
    class NumbersFromNToOneExercise
    {
        static void Main(string[] args)
        {
            var number = int.Parse(
                Console.ReadLine());

            for (var i = number;
                i > 0;
                i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
