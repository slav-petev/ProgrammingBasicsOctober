using System;

namespace _12.Volleyball
{
    class VolleyballExcercise
    {
        static void Main(string[] args)
        {
            var yearType = Console.ReadLine();
            var holidays = int.Parse(
                Console.ReadLine());
            var weekendsInHomeTown = int.Parse(
                Console.ReadLine());

            var weekendsInYear = 48;
            var numberOfWeekendsInSofia = 
                weekendsInYear - weekendsInHomeTown;
            var numberOfVolleyballWeekendsInSofia = 
                3.0 * numberOfWeekendsInSofia / 4.0;
            var volleyballHolidays = 
                2.0 * holidays / 3.0;
            var numberOfVolleyballDaysInSofia = 
                numberOfVolleyballWeekendsInSofia + 
                volleyballHolidays;

            var numberOfVolleyballDaysInHomeTown = weekendsInHomeTown;

            var numberOfVolleyBallDaysInYear = 
                numberOfVolleyballDaysInSofia + 
                numberOfVolleyballDaysInHomeTown;

            if (yearType == "leap")
            {
                numberOfVolleyBallDaysInYear *= 1.15;
            }

            Console.WriteLine(
                (int)(numberOfVolleyBallDaysInYear));
        }
    }
}
