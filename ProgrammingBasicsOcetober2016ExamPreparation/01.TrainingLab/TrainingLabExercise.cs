using System;

namespace _01.TrainingLab
{
    class TrainingLabExercise
    {
        static void Main(string[] args)
        {
            var hallLengthInMeters =
                double.Parse(Console.ReadLine());
            var hallWidthInMeters =
                double.Parse(Console.ReadLine());

            var hallLengthInCentimeters =
                hallLengthInMeters * 100;
            var hallWidthInCentimeters =
                hallWidthInMeters * 100;

            var numberOfBenchesPerLength =
                Math.Truncate(
                    hallLengthInCentimeters / 120);

            var usableHallWidthInCentimeters =
                hallWidthInCentimeters - 100;
            var numberOfBenchesPerWidth =
                Math.Truncate(
                    usableHallWidthInCentimeters / 70);

            var numberOfBenchesInHall =
                Math.Truncate(numberOfBenchesPerLength *
                numberOfBenchesPerWidth);
            var actualNumberOfBenchesInHall =
                numberOfBenchesInHall - 3;

            Console.WriteLine(actualNumberOfBenchesInHall);

        }
    }
}
