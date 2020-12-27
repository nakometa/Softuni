using System;

namespace _09.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            string year = Console.ReadLine();
            double holidays = int.Parse(Console.ReadLine());
            double weekendsAtHome = int.Parse(Console.ReadLine());

            // Calculations
            double weekendsAtSofia = 48 - weekendsAtHome;
            double gamesAtSofia = weekendsAtSofia * 3 / 4;
            double gamesAtHome = weekendsAtHome;
            double gamesDuringHolidays = holidays * 2 / 3;
            double totalGames = gamesAtHome + gamesAtSofia + gamesDuringHolidays;

            if (year == "leap")
            {
                totalGames += (totalGames * 0.15);
                Console.WriteLine(Math.Floor(totalGames));
            }
            else
            {
                Console.WriteLine(Math.Floor(totalGames));
            }
        }
    }
}
