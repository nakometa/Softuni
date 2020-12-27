using System;

namespace _02.SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            int holidays = int.Parse(Console.ReadLine());

            // Calculations
            int workDays = 365 - holidays;
            int playTime = (workDays * 63) + (holidays * 127);


            if (playTime <= 30000)
            {
                double playTimeHours = (30000 - playTime) / 60;
                double playTimeMinutes = (30000 - playTime) % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{playTimeHours} hours and {playTimeMinutes} minutes less for play");
            }
            else
            {
                double playTimeHours = (playTime - 30000) / 60;
                double playTimeMinutes = (playTime - 30000) % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{playTimeHours} hours and {playTimeMinutes} minutes more for play");
            }
        }
    }
}
