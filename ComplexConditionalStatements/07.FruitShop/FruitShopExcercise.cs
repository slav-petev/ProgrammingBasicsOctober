using System;

namespace _07.FruitShop
{
    class FruitShopExcercise
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine();
            var dayOfWeek = Console.ReadLine()
                .ToLower();
            var quantity = double.Parse(
                Console.ReadLine());

            var fruitPrice = -1.0;
            switch (dayOfWeek)
            {
                case "monday":
                case "tuesday":
                case "wednesday":
                case "thursday":
                case "friday":
                    var bananaWeekPricePerKg = 2.5;
                    var appleWeekPricePerKg = 1.2;
                    var orangeWeekPricePerKg = 0.85;
                    var grapefruitWeekPricePerKg = 1.45;
                    var kiwiWeekPricePerKg = 2.7;
                    var pineappleWeekPricePerKg = 5.5;
                    var grapesWeekPricePerKg = 3.85;
 
                    switch (fruit)
                    {
                        case "banana":
                            fruitPrice = quantity *
                                bananaWeekPricePerKg;
                            break;
                        case "apple":
                            fruitPrice = quantity *
                                appleWeekPricePerKg;
                            break;
                        case "orange":
                            fruitPrice = quantity *
                                orangeWeekPricePerKg;
                            break;
                        case "grapefruit":
                            fruitPrice = quantity *
                                grapefruitWeekPricePerKg;
                            break;
                        case "kiwi":
                            fruitPrice = quantity *
                                kiwiWeekPricePerKg;
                            break;
                        case "pineapple":
                            fruitPrice = quantity *
                                pineappleWeekPricePerKg;
                            break;
                        case "grapes":
                            fruitPrice = quantity *
                                grapesWeekPricePerKg;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "saturday":
                case "sunday":
                    var bananaWeekendPricePerKg = 2.7;
                    var appleWeekendPricePerKg = 1.25;
                    var orangeWeekendPricePerKg = 0.9;
                    var grapefruitWeekendPricePerKg = 1.6;
                    var kiwiWeekendPricePerKg = 3.0;
                    var pineappleWeekendPricePerKg = 5.6;
                    var grapesWeekendPricePerKg = 4.20;

                    switch (fruit)
                    {
                        case "banana":
                            fruitPrice = quantity *
                                bananaWeekendPricePerKg;
                            break;
                        case "apple":
                            fruitPrice = quantity *
                                appleWeekendPricePerKg;
                            break;
                        case "orange":
                            fruitPrice = quantity *
                                orangeWeekendPricePerKg;
                            break;
                        case "grapefruit":
                            fruitPrice = quantity *
                                grapefruitWeekendPricePerKg;
                            break;
                        case "kiwi":
                            fruitPrice = quantity *
                                kiwiWeekendPricePerKg;
                            break;
                        case "pineapple":
                            fruitPrice = quantity *
                                pineappleWeekendPricePerKg;
                            break;
                        case "grapes":
                            fruitPrice = quantity *
                                grapesWeekendPricePerKg;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }

            if (fruitPrice > -1.0)
            {
                Console.WriteLine("{0:F2}",
                        fruitPrice); 
            }
        }
    }
}
