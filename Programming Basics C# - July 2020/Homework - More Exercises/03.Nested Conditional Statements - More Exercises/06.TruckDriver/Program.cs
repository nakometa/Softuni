using System;

namespace _06.TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            string season = Console.ReadLine();
            double kilometersPerMonth = double.Parse(Console.ReadLine());

            // Calculations
            double earningPerKM = 0;
            switch (season)
            {
                case "Spring":
                case "Autumn":
                    if (kilometersPerMonth <= 5000)
                    {
                        earningPerKM = 0.75;
                    }
                    else if (kilometersPerMonth > 5000 && kilometersPerMonth <= 10000)
                    {
                        earningPerKM = 0.95;
                    }
                    else
                    {
                        earningPerKM = 1.45;
                    }
                    break;
                case "Summer":
                    if (kilometersPerMonth <= 5000)
                    {
                        earningPerKM = 0.9;
                    }
                    else if (kilometersPerMonth > 5000 && kilometersPerMonth <= 10000)
                    {
                        earningPerKM = 1.10;
                    }
                    else
                    {
                        earningPerKM = 1.45;
                    }
                    break;
                case "Winter":
                    if (kilometersPerMonth <= 5000)
                    {
                        earningPerKM = 1.05;
                    }
                    else if (kilometersPerMonth > 5000 && kilometersPerMonth <= 10000)
                    {
                        earningPerKM = 1.25;
                    }
                    else
                    {
                        earningPerKM = 1.45;
                    }
                    break;
            }
            double totalEarnings = (earningPerKM * kilometersPerMonth * 4) * 0.9;
            Console.WriteLine($"{totalEarnings:F2}");
        }
    }
}
