using System;

namespace _01.Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int washingLiquidNeeded = 0;
            int liquidRequired = 0;
            string washingLiquidTubes = Console.ReadLine();
            int washingLiquid = int.Parse(washingLiquidTubes) * 750;
            int counter = 1;
            string dishes = Console.ReadLine();
            int totalPots = 0;
            int totalDishes = 0;
            bool isEnough = true;

            while (dishes != "End")
            {
                int dishesAmount = int.Parse(dishes);

                if (counter % 3 == 0)
                {
                    washingLiquidNeeded = dishesAmount * 15;
                    totalPots += dishesAmount;

                    if (washingLiquid < washingLiquidNeeded)
                    {
                        isEnough = false;
                        liquidRequired = washingLiquidNeeded - washingLiquid;
                        Console.WriteLine($"Not enough detergent, {liquidRequired} ml. more necessary!");
                        break;
                    }
                    washingLiquid -= washingLiquidNeeded;
                }
                else
                {
                    washingLiquidNeeded = dishesAmount * 5;
                    totalDishes += dishesAmount;

                    if (washingLiquid < washingLiquidNeeded)
                    {
                        isEnough = false;
                        liquidRequired = washingLiquidNeeded - washingLiquid;
                        Console.WriteLine($"Not enough detergent, {liquidRequired} ml. more necessary!");
                        break;
                    }
                    washingLiquid -= washingLiquidNeeded;
                }
                counter++;
                dishes = Console.ReadLine();
            }
            if (isEnough == true)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{totalDishes} dishes and {totalPots} pots were washed.");
                Console.WriteLine($"Leftover detergent {washingLiquid} ml.");
            }
        }
    }
}
