using System;

namespace _02.Harvest
{
    class HarvestExercise
    {
        static void Main(string[] args)
        {
            var vineyardArea = int.Parse(
                Console.ReadLine());
            var grapesPerSquareMeter = 
                double.Parse(Console.ReadLine());
            var litresOfWineNeeded = int.Parse(
                Console.ReadLine());
            var numberOfWorkers = int.Parse(
                Console.ReadLine());

            var totalGrapesInKg = vineyardArea *
                grapesPerSquareMeter;
            var grapesForWineInKg = totalGrapesInKg * 
                0.4;
            var actualLitresOfWine = grapesForWineInKg / 
                2.5;

            if (actualLitresOfWine < litresOfWineNeeded)
            {
                var additionalLitresOfWineNeeded =
                    Math.Floor(litresOfWineNeeded -
                        actualLitresOfWine);
                Console.Write("It will be a tough winter! ");
                Console.WriteLine("More {0} liters wine needed.",
                    additionalLitresOfWineNeeded);
            }
            else
            {
                Console.Write("Good harvest this year! ");
                Console.WriteLine("Total wine: {0} liters.",
                    Math.Floor(
                        actualLitresOfWine));
                var litresOfWineRemaining =
                    Math.Ceiling(
                        actualLitresOfWine - 
                        litresOfWineNeeded);
                var litresOfWinePerWorker =
                    Math.Ceiling(
                        litresOfWineRemaining /
                        numberOfWorkers);
                Console.Write("{0} liters left -> ",
                    litresOfWineRemaining);
                Console.WriteLine("{0} liters per person.",
                    litresOfWinePerWorker);
            }
        }
    }
}
