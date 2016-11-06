using System;

namespace _05.InvalidNumber
{
    class InvalidNumberExcercise
    {
        static void Main(string[] args)
        {
            var number = int.Parse(
                Console.ReadLine());

            var isNumberInvalid =
                number != 0 &&
                (number < 100 ||
                number > 200);

            if (isNumberInvalid)
            {
                Console.WriteLine("invalid");
            }
                
        }
    }
}
