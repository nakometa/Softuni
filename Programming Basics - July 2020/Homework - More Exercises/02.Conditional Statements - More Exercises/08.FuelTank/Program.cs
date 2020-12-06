using System;

namespace _08.FuelTank
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double fuelLiters = double.Parse(Console.ReadLine());

            switch (fuelType)
            {
                case "Diesel":
                    if (fuelLiters >= 25)
                    {
                        Console.WriteLine("You have enough diesel.");
                    }
                    else
                    {
                        Console.WriteLine("Fill your tank with diesel!");
                    }
                    break;
                case "Gasoline":
                    if (fuelLiters >= 25)
                    {
                        Console.WriteLine("You have enough gasoline.");
                    }
                    else
                    {
                        Console.WriteLine("Fill your tank with gasoline!");
                    }
                    break;
                case "Gas":
                    if (fuelLiters >= 25)
                    {
                        Console.WriteLine("You have enough gas.");
                    }
                    else
                    {
                        Console.WriteLine("Fill your tank with gas!");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid fuel!");
                    break;
            }
        }
    }
}
