using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PasswordGuess
{
    class PasswordGuessExercise
    {
        static void Main(string[] args)
        {
            var userEnteredPassword =
                Console.ReadLine();

            var correctPassword = "s3cr3t!P@ssw0rd";

            if (userEnteredPassword == correctPassword)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }


        }
    }
}
