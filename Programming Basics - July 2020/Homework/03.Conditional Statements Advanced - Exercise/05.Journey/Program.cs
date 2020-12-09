using System;

namespace _05.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            // Output
            if (budget <= 100)
            {
                if (season == "summer")
                {
                    budget = budget * 0.3;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {budget:F2}");
                }
                else
                {
                    budget = budget * 0.7;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {budget:F2}");

                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                if (season == "summer")
                {
                    budget = budget * 0.4;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Camp - {budget:F2}");
                }
                else
                {
                    budget = budget * 0.8;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {budget:F2}");

                }
            }
            else
            {
                budget = budget * 0.9;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {budget:F2}");
            }
        }
    }
}
