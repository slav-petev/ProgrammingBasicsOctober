using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Diamond
{
    class DiamondExercise
    {
        static void Main(string[] args)
        {
            var diamondSize = int.Parse(
                Console.ReadLine());

            /* We will divide the diamond into several parts -
               peak, which is the topmost row, upperBody, which
               consists of the next
            */

            //We start looking at the peak
            var numberOfStars = diamondSize % 2 == 0
                ? 2
                : 1;
            var numberOfDashesPerSide =
                diamondSize % 2 == 0
                ? diamondSize / 2 - 1
                : diamondSize / 2;
            Console.WriteLine("{0}{1}{0}",
                new string('-', numberOfDashesPerSide),
                new string('*', numberOfStars));

            //Now we move on to the upperBody part
            var upperBodyHeight = diamondSize % 2 == 0
                ? (diamondSize / 2 - 1) - 1
                : diamondSize / 2 - 1;
            var numberOfDashesPerSideInUpeerBodyPart =
                diamondSize % 2 == 0
                ? (diamondSize / 2 - 1) - 1
                : diamondSize / 2 - 1;
            var numberOfDashesBetweenStarsInUpperBodyPart =
                diamondSize % 2 == 0
                ? 2
                : 1;

            for (var currentRow = 0;
                currentRow < upperBodyHeight;
                currentRow++)
            {
                Console.WriteLine("{0}*{1}*{0}",
                    new string('-', numberOfDashesPerSideInUpeerBodyPart),
                    new string('-', numberOfDashesBetweenStarsInUpperBodyPart));

                numberOfDashesPerSideInUpeerBodyPart--;
                numberOfDashesBetweenStarsInUpperBodyPart += 2;
            }

            //Now we move on to the spine
            var numberOfDashesBetweenStarsInBase =
                diamondSize - 2;

            Console.WriteLine("*{0}*",
                new string('-', 
                    numberOfDashesBetweenStarsInBase));

            //Now we move on to the lowerBody part
            var lowerBodyHeight = diamondSize % 2 == 0
                ? (diamondSize / 2 - 1) - 1
                : diamondSize / 2 - 1;
            var numberOfDashesPerSideInLowerBody = 1;
            var numberOfDashesBetweenStarsInLowerBody =
                diamondSize % 2 == 0
                ? diamondSize / 2 - 1
                : diamondSize / 2;

            for (var currentRow = 0;
                currentRow < lowerBodyHeight;
                currentRow++)
            {
                Console.WriteLine("{0}*{1}*{0}",
                    new string('-', numberOfDashesPerSideInLowerBody),
                    new string('-', numberOfDashesBetweenStarsInLowerBody));

                numberOfDashesPerSideInLowerBody++;
                numberOfDashesBetweenStarsInLowerBody -= 2;
            }

            //Now we move on to the base
            var numberOfStarsInBase = diamondSize % 2 == 0
                ? 2
                : 1;
            var numberOfDashesPerSideInBase =
                diamondSize % 2 == 0
                ? diamondSize / 2 - 1
                : diamondSize / 2;

            Console.WriteLine("{0}{1}{0}",
                new string('-', numberOfDashesPerSideInBase),
                new string('*', numberOfStarsInBase));
        }
    }
}
