using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BonusScore
{
    class BonusScoreExercise
    {
        static void Main(string[] args)
        {
            var inputNumber = double.Parse(
                Console.ReadLine());

            var bonusPoints = 0.0;
            if (inputNumber <= 100)
            {
                bonusPoints = 5;
            }
            else if (100 < inputNumber &&
                    inputNumber <= 1000)
            {
                bonusPoints = 0.2 * inputNumber;
            }
            else
            {
                bonusPoints = 0.1 * inputNumber;
            }

            var aditionalBonusPoints = 0.0;
            if (inputNumber % 2 == 0)
            {
                aditionalBonusPoints = 1;
            }
            else if (inputNumber % 10 == 5)
            {
                aditionalBonusPoints = 2;
            }

            var totalBonusPoints = bonusPoints +
                aditionalBonusPoints;
            var finalNumber = inputNumber +
                totalBonusPoints;

            Console.WriteLine(totalBonusPoints);
            Console.WriteLine(finalNumber);
        }
    }
}
