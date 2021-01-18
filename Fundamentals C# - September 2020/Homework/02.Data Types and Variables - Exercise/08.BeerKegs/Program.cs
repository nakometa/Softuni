using System;

namespace _08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var biggestCog = double.MinValue;
            var bestCog = string.Empty;

            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                var height = int.Parse(Console.ReadLine());
                double currentVolume = Math.PI * Math.Pow(radius, 2) * height;
                if (currentVolume > biggestCog)
                {
                    biggestCog = currentVolume;
                    bestCog = name;
                }
            }
            Console.WriteLine(bestCog);
        }
    }
}
