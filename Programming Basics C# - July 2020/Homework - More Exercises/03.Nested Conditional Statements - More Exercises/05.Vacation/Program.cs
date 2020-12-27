using System;

namespace _05.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string location = "";
            double totalPrice = 0;

            // Calculations
            if (budget <= 1000)
            {
                location = "Camp";
                if (season == "Summer")
                {
                    totalPrice = budget * 0.65;
                    Console.WriteLine($"Alaska - {location} - {totalPrice:f2}");
                }
                else
                {
                    totalPrice = budget * 0.45;
                    Console.WriteLine($"Morocco - {location} - {totalPrice:f2}");
                }
            }
            else if (budget > 1000 && budget <= 3000)
            {
                location = "Hut";
                if (season == "Summer")
                {
                    totalPrice = budget * 0.8;
                    Console.WriteLine($"Alaska - {location} - {totalPrice:f2}");
                }
                else
                {
                    totalPrice = budget * 0.6;
                    Console.WriteLine($"Morocco - {location} - {totalPrice:f2}");
                }
            }
            else if (budget > 3000)
            {
                location = "Hotel";
                if (season == "Summer")
                {
                    totalPrice = budget * 0.9;
                    Console.WriteLine($"Alaska - {location} - {totalPrice:f2}");
                }
                else
                {
                    totalPrice = budget * 0.9;
                    Console.WriteLine($"Morocco - {location} - {totalPrice:f2}");
                }
            }
        }
    }
}
