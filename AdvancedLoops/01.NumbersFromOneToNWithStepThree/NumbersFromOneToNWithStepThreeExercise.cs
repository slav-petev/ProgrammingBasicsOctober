using System;

namespace _01.NumbersFromOneToNWithStepThree
{
    class NumbersFromOneToNWithStepThreeExercise
    {
        static void Main(string[] args)
        {
            var number = int.Parse(
                Console.ReadLine());

            for (var i = 1;
                i <= number;
                i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
