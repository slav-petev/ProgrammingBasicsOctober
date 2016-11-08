using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.TimePlusFifteenMinutes
{
    class TimePlusFifteenMinutesExercise
    {
        static void Main(string[] args)
        {
            var currentHour = int.Parse(
                Console.ReadLine());
            var currentMinutes = int.Parse(
                Console.ReadLine());

            var currentHourInMinutes =
                currentHour * 60;
            var currentTimeInMinutes =
                currentHourInMinutes +
                currentMinutes;

            var timeAfterFifteenMinutesInMinutes =
                currentTimeInMinutes + 15;

            var hourAfterFifteenMinutes =
                timeAfterFifteenMinutesInMinutes / 60;
            var minutesAfterFifteenMinutes =
                timeAfterFifteenMinutesInMinutes % 60;

            /*
                We need to display the hours as a number
                between 0 and 23. When we divide by 60,
                it is possible to get 24. So, using the
                % operator, we get the desired value 
                between 0 and 23.
            */
            var hourAfterFifteenMinutesDisplayValue =
                hourAfterFifteenMinutes % 24;

            Console.WriteLine("{0}:{1:00}",
                hourAfterFifteenMinutesDisplayValue,
                minutesAfterFifteenMinutes);
        }
    }
}
