using System;

namespace _08.FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int witdh = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentSpaceTaken = double.Parse(Console.ReadLine());

            int fishTankVolume = lenght * witdh * height;
            double fishTankVolumeInLiters = fishTankVolume * 0.001;
            double totalPercentSpaceTaken = percentSpaceTaken * 0.01;

            double freeSpace = fishTankVolumeInLiters - (fishTankVolumeInLiters * totalPercentSpaceTaken);

            Console.WriteLine(freeSpace);

        }
    }
}
