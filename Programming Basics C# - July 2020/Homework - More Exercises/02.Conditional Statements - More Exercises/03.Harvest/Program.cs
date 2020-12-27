using System;

namespace _03.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            int vineyardLength = int.Parse(Console.ReadLine());
            double grapePerSquareMeter = double.Parse(Console.ReadLine());
            int wineNeeded = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            // Calculations 
            double totalGrapeForWine = (vineyardLength * grapePerSquareMeter) * 0.4;
            double totalWineProduced = totalGrapeForWine / 2.5;

            // Output 
            if (totalWineProduced < wineNeeded)
            {
                double lackOfWine = Math.Floor(wineNeeded - totalWineProduced);
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(lackOfWine)} liters wine needed.");
            }
            else if (totalWineProduced >= wineNeeded)
            {
                double wineLeft = totalWineProduced - wineNeeded;
                double winePerWorker = wineLeft / workers;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(totalWineProduced)} liters.");
                Console.WriteLine($"{Math.Ceiling(wineLeft)} liters left -> {Math.Ceiling(winePerWorker)} liters per person.");
            }
        }
    }
}
