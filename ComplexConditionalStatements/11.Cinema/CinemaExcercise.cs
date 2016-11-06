using System;

namespace _11.Cinema
{
    class CinemaExcercise
    {
        static void Main(string[] args)
        {
            var projectionType = 
                Console.ReadLine();
            var numberOfRowsInHall =
                int.Parse(Console.ReadLine());
            var numberOfColumnsInHall =
                int.Parse(Console.ReadLine());

            var numberOfSeatsInHall =
                numberOfRowsInHall *
                numberOfColumnsInHall;
            var premierePrice = 12.00;
            var normalPrice = 7.50;
            var discountPrice = 5.00;
            var totalIncome = -1.00;

            switch (projectionType)
            {
                case "Premiere":
                    totalIncome =
                        numberOfSeatsInHall *
                        premierePrice;
                    break;
                case "Normal":
                    totalIncome =
                        numberOfSeatsInHall *
                        normalPrice;
                    break;
                case "Discount":
                    totalIncome =
                        numberOfSeatsInHall *
                        discountPrice;
                    break;
            }

            Console.WriteLine("{0:F2}",
                totalIncome);
        }
    }
}
