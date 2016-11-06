using System;

namespace _04.FruitOrVegetable
{
    class FruitOrVegetableExcercise
    {
        static void Main(string[] args)
        {
            var productName = Console.ReadLine();

            switch (productName)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    Console.WriteLine("fruit");
                    break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    Console.WriteLine("vegetable");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
