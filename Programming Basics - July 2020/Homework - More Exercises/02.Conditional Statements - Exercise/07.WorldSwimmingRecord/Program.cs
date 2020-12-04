using System;

namespace _07.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            double record = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeInSeconds = double.Parse(Console.ReadLine());

            // Calculations
            double swimTime = distanceInMeters * timeInSeconds;
            double delay = Math.Floor(distanceInMeters / 15) * 12.5;
            double totalSwimTime = swimTime + delay;

            // Output
            if (totalSwimTime < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalSwimTime:F2} seconds.");
            }
            else
            {
                double neededTime = totalSwimTime - record;
                Console.WriteLine($"No, he failed! He was {neededTime:F2} seconds slower.");
            }
        }
    }
}
