using System;

namespace _05.Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input 
            int hoursNeeded = int.Parse(Console.ReadLine());
            int daysLeft = int.Parse(Console.ReadLine());
            int emergencyWorkers = int.Parse(Console.ReadLine());

            // Calculations
            double workingHours = (daysLeft * 0.9) * 8;
            double emergencyHours = (emergencyWorkers * daysLeft) * 2;
            double totalWorkingHours = Math.Floor(workingHours + emergencyHours);

            // Output
            if (totalWorkingHours >= hoursNeeded)
            {
                double timeLeft = totalWorkingHours - hoursNeeded;
                Console.WriteLine($"Yes!{timeLeft} hours left.");
            }
            else
            {
                double timeNeeded = hoursNeeded - totalWorkingHours;
                Console.WriteLine($"Not enough time!{timeNeeded} hours needed.");
            }
        }
    }
}
