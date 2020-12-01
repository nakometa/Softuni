using System;

namespace _05.TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double wInCentimeters = w * 100;
            double hInCentimeters = h * 100 - 100;

            double wDesk = Math.Floor(wInCentimeters / 120);
            double hDesk = Math.Floor(hInCentimeters / 70);
            double totalDeskSpace = wDesk * hDesk - 3;

            Console.WriteLine(totalDeskSpace);
        }
    }
}
