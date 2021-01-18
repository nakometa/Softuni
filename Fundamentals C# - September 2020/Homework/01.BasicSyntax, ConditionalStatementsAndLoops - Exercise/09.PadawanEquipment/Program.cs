using System;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var students = int.Parse(Console.ReadLine());
            var lightsabersPrice = double.Parse(Console.ReadLine());
            var robesPrice = double.Parse(Console.ReadLine());
            var beltsPrice = double.Parse(Console.ReadLine());
            var beltsCount = students;
            var counter = 0;
            //
            var lightsabersCost = Math.Ceiling(students * 1.1) * lightsabersPrice;
            var robesCost = robesPrice * students;
            for (int i = 1; i <= students; i++)
            {
                counter++;
                if (counter % 6 == 0)
                {
                    beltsCount--;
                }
            }
            var beltsCost = beltsCount * beltsPrice;
            var totalCost = lightsabersCost + robesCost + beltsCost;
            if (money >= totalCost)
            {
                Console.WriteLine($"The money is enough - it would cost {totalCost:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalCost - money:F2}lv more.");
            }
        }
    }
}
