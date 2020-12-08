using System;

namespace _03.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            string flowerType = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            // Output 
            if (flowerType == "Roses")
            {
                if (flowerCount > 80)
                {
                    totalPrice += (flowerCount * 5) * 0.9;
                }
                else
                {
                    totalPrice += flowerCount * 5;
                }
            }
            else if (flowerType == "Dahlias")
            {
                if (flowerCount > 90)
                {
                    totalPrice += (flowerCount * 3.8) * 0.85;
                }
                else
                {
                    totalPrice += flowerCount * 3.8;
                }
            }
            else if (flowerType == "Tulips")
            {
                if (flowerCount > 80)
                {
                    totalPrice += (flowerCount * 2.8) * 0.85;
                }
                else
                {
                    totalPrice += flowerCount * 2.8;
                }
            }
            else if (flowerType == "Narcissus")
            {
                if (flowerCount < 120)
                {
                    totalPrice += (flowerCount * 3) * 1.15;
                }
                else
                {
                    totalPrice += flowerCount * 3;
                }
            }
            else if (flowerType == "Gladiolus")
            {
                if (flowerCount < 80)
                {
                    totalPrice += (flowerCount * 2.5) * 1.2;
                }
                else
                {
                    totalPrice += flowerCount * 2.5;
                }
            }

            if (budget >= totalPrice)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowerType} and {moneyLeft:F2} leva left.");
            }
            else
            {
                double moneyNeeded = totalPrice - budget;
                Console.WriteLine($"Not enough money, you need {moneyNeeded:F2} leva more.");
            }
        }
    }
}
