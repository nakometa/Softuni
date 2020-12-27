using System;

namespace _04.TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            int km = int.Parse(Console.ReadLine());
            string timeOfTravel = Console.ReadLine();
            double price = 0;

            // Output
            if (km < 20 && timeOfTravel == "day")
            {
                price = 0.7 + (km * 0.79);
            }
            else if (km < 20 && timeOfTravel == "night")
            {
                price = 0.7 + (km * 0.9);
            }
            else if (km < 100 && timeOfTravel == "day")
            {
                price = 0.09 * km;
            }
            else if (km < 100 && timeOfTravel == "night")
            {
                price = 0.09 * km;
            }
            else if (km >= 100 && timeOfTravel == "day" || timeOfTravel == "night")
            {
                price = 0.06 * km;
            }

            Math.Floor(price);
            Console.WriteLine($"{price:F2}");
        }
    }
}
