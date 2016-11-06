using System;

namespace _08.TradeComissions
{
    class TradeComissionsExcercise
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine()
                .ToLower();
            var numberOfSales = double.Parse(
                Console.ReadLine());

            var comissionRate = -1.0;
            switch (town)
            {
                case "sofia":
                    if (0 <= numberOfSales && numberOfSales <= 500)
                    {
                        comissionRate = 0.05;
                    }
                    else if (500 < numberOfSales && numberOfSales <= 1000)
                    {
                        comissionRate = 0.07;
                    }
                    else if (1000 < numberOfSales && numberOfSales <= 10000)
                    {
                        comissionRate = 0.08;
                    }
                    else if (10000 < numberOfSales)
                    {
                        comissionRate = 0.12;
                    }
                    break;
                case "varna":
                    if (0 <= numberOfSales && numberOfSales <= 500)
                    {
                        comissionRate = 0.045;
                    }
                    else if (500 < numberOfSales && numberOfSales <= 1000)
                    {
                        comissionRate = 0.075;
                    }
                    else if (1000 < numberOfSales && numberOfSales <= 10000)
                    {
                        comissionRate = 0.1;
                    }
                    else if (10000 < numberOfSales)
                    {
                        comissionRate = 0.13;
                    }
                    break;
                case "plovdiv":
                    if (0 <= numberOfSales && numberOfSales <= 500)
                    {
                        comissionRate = 0.055;
                    }
                    else if (500 < numberOfSales && numberOfSales <= 1000)
                    {
                        comissionRate = 0.08;
                    }
                    else if (1000 < numberOfSales && numberOfSales <= 10000)
                    {
                        comissionRate = 0.12;
                    }
                    else if (10000 < numberOfSales)
                    {
                        comissionRate = 0.145;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }

            if (numberOfSales >= 0)
            {
                var tradeComission =
                    numberOfSales * comissionRate;
                Console.WriteLine("{0:F2}",
                    tradeComission);
            }
            else
            {
                Console.WriteLine("error");
            } 
        }
    }
}
