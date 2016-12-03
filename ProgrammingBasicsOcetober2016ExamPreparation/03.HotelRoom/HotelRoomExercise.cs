using System;

namespace _03.HotelRoom
{
    class HotelRoomExercise
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var numberOfNights = int.Parse(
                Console.ReadLine());

            var apartmentPrice = 0.0;
            var studioPrice = 0.0;
            switch (month)
            {
                case "May":
                case "October":
                    apartmentPrice = 65.0;
                    studioPrice = 50.0;
                    if (numberOfNights > 7 &&
                        numberOfNights <= 14)
                    {
                        studioPrice *= 0.95;
                    }
                    else if (numberOfNights > 14)
                    {
                        studioPrice *= 0.7;
                    }
                    break;
                case "June":
                case "September":
                    apartmentPrice = 68.70;
                    studioPrice = 75.20;
                    if (numberOfNights > 14)
                    {
                        studioPrice *= 0.8;
                    }
                    break;
                default:
                    apartmentPrice = 77.0;
                    studioPrice = 76.0;
                    break;
            }

            if (numberOfNights > 14)
            {
                apartmentPrice *= 0.9;
            }

            Console.WriteLine("Apartment: {0:F2} lv.",
                apartmentPrice * numberOfNights);
            Console.WriteLine("Studio: {0:F2} lv.",
                studioPrice * numberOfNights);
        }
    }
}
