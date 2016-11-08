using System;

namespace _01.ExcellentResult
{
    class ExcellentResultExercise
    {
        static void Main(string[] args)
        {
            var grade = double.Parse(
                Console.ReadLine());

            if (grade >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
