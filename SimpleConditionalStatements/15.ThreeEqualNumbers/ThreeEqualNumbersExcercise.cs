using System;

namespace _15.ThreeEqualNumbers
{
    class ThreeEqualNumbersExercise
    {
        static void Main(string[] args)
        {
            var firstNumber = double.Parse(
                Console.ReadLine());
            var secondNumber = double.Parse(
                Console.ReadLine());
            var thirdNumber = double.Parse(
                Console.ReadLine());

            if (firstNumber == secondNumber &&
                secondNumber == thirdNumber)
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
