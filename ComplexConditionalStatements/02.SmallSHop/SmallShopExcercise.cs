using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SmallSHop
{
    class SmallShopExcercise
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine()
                .ToLower();
            var town = Console.ReadLine()
                .ToLower();
            var quantity = double.Parse(
                Console.ReadLine());
            
            if (town == "sofia")
            {
                var coffeePriceInSofia = 0.5;
                var waterPriceInSofia = 0.8;
                var beerPriceInSofia = 1.2;
                var sweetsPriceInSofia = 1.45;
                var peanutsPriceInSofia = 1.6;

                switch (product)
                {
                    case "coffee":
                        Console.WriteLine(
                            quantity * 
                            coffeePriceInSofia);
                        break;
                    case "water":
                        Console.WriteLine(
                            quantity *
                            waterPriceInSofia);
                        break;
                    case "beer":
                        Console.WriteLine(
                            quantity *
                            beerPriceInSofia);
                        break;
                    case "sweets":
                        Console.WriteLine(
                            quantity *
                            sweetsPriceInSofia);
                        break;
                    case "peanuts":
                        Console.WriteLine(
                            quantity *
                            peanutsPriceInSofia);
                        break;
                }
            }
            else if (town == "plovdiv")
            {
                var coffeePriceInPlovdiv = 0.4;
                var waterPriceInPlovdiv = 0.7;
                var beerPriceInPlovdiv = 1.15;
                var sweetsPriceInPlovdiv = 1.3;
                var peanutsPriceInPlovdiv = 1.5;

                switch (product)
                {
                    case "coffee":
                        Console.WriteLine(
                            quantity *
                            coffeePriceInPlovdiv);
                        break;
                    case "water":
                        Console.WriteLine(
                            quantity *
                            waterPriceInPlovdiv);
                        break;
                    case "beer":
                        Console.WriteLine(
                            quantity *
                            beerPriceInPlovdiv);
                        break;
                    case "sweets":
                        Console.WriteLine(
                            quantity *
                            sweetsPriceInPlovdiv);
                        break;
                    case "peanuts":
                        Console.WriteLine(
                            quantity *
                            peanutsPriceInPlovdiv);
                        break;
                }
            }
            else if (town == "varna")
            {
                var coffeePriceInVarna = 0.45;
                var waterPriceInVarna = 0.7;
                var beerPriceInVarna = 1.1;
                var sweetsPriceInVarna = 1.35;
                var peanutsPriceInVarna = 1.55;

                switch (product)
                {
                    case "coffee":
                        Console.WriteLine(
                            quantity *
                            coffeePriceInVarna);
                        break;
                    case "water":
                        Console.WriteLine(
                            quantity *
                            waterPriceInVarna);
                        break;
                    case "beer":
                        Console.WriteLine(
                            quantity *
                            beerPriceInVarna);
                        break;
                    case "sweets":
                        Console.WriteLine(
                            quantity *
                            sweetsPriceInVarna);
                        break;
                    case "peanuts":
                        Console.WriteLine(
                            quantity *
                            peanutsPriceInVarna);
                        break;
                }
            }
        }
    }
}
