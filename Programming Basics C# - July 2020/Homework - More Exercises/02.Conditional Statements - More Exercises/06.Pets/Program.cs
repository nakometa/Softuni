using System;

namespace _06.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            int days = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());
            double kilogramsDogFoodForDay = double.Parse(Console.ReadLine());
            double kilogramsCatFoodForDay = double.Parse(Console.ReadLine());
            double gramsTurtleFoodForDay = double.Parse(Console.ReadLine());

            // Calculations
            double dogFoodNeeded = days * kilogramsDogFoodForDay;
            double catFoodNeeded = days * kilogramsCatFoodForDay;
            double kilogramsTurtleFoodNeeded = days * (gramsTurtleFoodForDay / 1000);
            double totalFood = dogFoodNeeded + catFoodNeeded + kilogramsTurtleFoodNeeded;

            if (totalFood <= foodLeft)
            {
                double notUsedFood = Math.Floor(foodLeft - totalFood);
                Console.WriteLine($"{notUsedFood} kilos of food left.");
            }
            else
            {
                double foodNeeded = Math.Ceiling(totalFood - foodLeft);
                Console.WriteLine($"{foodNeeded} more kilos of food are needed.");
            }
        }
    }
}
