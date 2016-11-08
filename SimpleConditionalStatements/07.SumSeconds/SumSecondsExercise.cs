using System;

namespace _07.SumSeconds
{
    class SumSecondsExercise
    {
        static void Main(string[] args)
        {
            var firstTimeInSeconds =
                int.Parse(Console.ReadLine());
            var secondTimeInSeconds =
                int.Parse(Console.ReadLine());
            var thirdTimeInSeconds =
                int.Parse(Console.ReadLine());

            var totalTimeInSeconds =
                firstTimeInSeconds +
                secondTimeInSeconds +
                thirdTimeInSeconds;

            var minutesInTotalTime =
                totalTimeInSeconds / 60;
            var secondsInTotalTime =
                totalTimeInSeconds % 60;

            Console.WriteLine("{0}:{1:00}",
                minutesInTotalTime,
                secondsInTotalTime);
        }
    }
}
