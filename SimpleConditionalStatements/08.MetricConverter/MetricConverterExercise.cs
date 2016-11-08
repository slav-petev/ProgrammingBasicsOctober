using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MetricConverter
{
    class MetricConverterExercise
    {
        static void Main(string[] args)
        {
            var length = double.Parse(Console.ReadLine());
            var sourceMeasureUnit = Console.ReadLine();
            var destinationMeasureUnit = Console.ReadLine();

            var lengthInMeters = length;
            var millimetersInMeter = 1000;
            var centimetersInMeter = 100;
            var milesInMeter = 0.000621371192;
            var inchesInMeter = 39.3700787;
            var kilometersInMeter = 0.001;
            var feetInMeter = 3.2808399;
            var yardsInMeter = 1.0936133;
            switch (sourceMeasureUnit)
            {
                case "mm":
                    lengthInMeters = length / millimetersInMeter;
                    break;
                case "cm":
                    lengthInMeters = length / centimetersInMeter;
                    break;
                case "mi":
                    lengthInMeters = length / milesInMeter;
                    break;
                case "in":
                    lengthInMeters = length / inchesInMeter;
                    break;
                case "km":
                    lengthInMeters = length / kilometersInMeter;
                    break;
                case "ft":
                    lengthInMeters = length / feetInMeter;
                    break;
                case "yd":
                    lengthInMeters = length / yardsInMeter;
                    break;
            }

            double lengthInDestinationMeasureUnit = lengthInMeters;

            switch (destinationMeasureUnit)
            {
                case "mm":
                    lengthInDestinationMeasureUnit =
                            lengthInMeters * millimetersInMeter;
                    break;
                case "cm":
                    lengthInDestinationMeasureUnit =
                            lengthInMeters * centimetersInMeter;
                    break;
                case "mi":
                    lengthInDestinationMeasureUnit =
                            lengthInMeters * milesInMeter;
                    break;
                case "in":
                    lengthInDestinationMeasureUnit =
                            lengthInMeters * inchesInMeter;
                    break;
                case "km":
                    lengthInDestinationMeasureUnit =
                            lengthInMeters * kilometersInMeter;
                    break;
                case "ft":
                    lengthInDestinationMeasureUnit =
                            lengthInMeters * feetInMeter;
                    break;
                case "yd":
                    lengthInDestinationMeasureUnit =
                            lengthInMeters * yardsInMeter;
                    break;
            }

            Console.WriteLine("{0} {1}",
                    lengthInDestinationMeasureUnit,
                    destinationMeasureUnit);
        }
    }
}
