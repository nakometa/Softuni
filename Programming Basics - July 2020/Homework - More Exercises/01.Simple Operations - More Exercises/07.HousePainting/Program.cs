using System;

namespace _07.HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double sideWall = x * y;
            double window = 1.5 * 1.5;
            double sideWallsTotal = sideWall + sideWall - window * 2;

            double frontWall = x * x;
            double door = 1.2 * 2;
            double frontAndBackWallsTotal = frontWall + frontWall - door;
            double downSpace = sideWallsTotal + frontAndBackWallsTotal;
            double downPaintNeeded = downSpace / 3.4;

            double roofSideWallsTotal = (x * y) * 2;
            double roofFrontAndBackWallsTotal = 2 * (x * h / 2);
            double roofTotalSpace = roofSideWallsTotal + roofFrontAndBackWallsTotal;
            double roofPaintNeeded = roofTotalSpace / 4.3;

            Console.WriteLine("{0:0.00}", downPaintNeeded);
            Console.WriteLine("{0:0.00}", roofPaintNeeded);
        }
    }
}
