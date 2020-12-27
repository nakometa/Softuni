using System;

namespace _08.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string boxes = Console.ReadLine();
            int totalBoxes = 0;
            int freeSpace = width * length * height;


            while (boxes != "Done")
            {
                int amount = int.Parse(boxes);
                totalBoxes += amount;
                if (freeSpace < totalBoxes)
                {
                    int spaceNeeded = Math.Abs(freeSpace - totalBoxes);
                    Console.WriteLine($"No more free space! You need {spaceNeeded} Cubic meters more.");
                    break;
                }
                boxes = Console.ReadLine();
            }

            if (freeSpace >= totalBoxes)
            {
                int spaceLeft = freeSpace - totalBoxes;
                Console.WriteLine($"{spaceLeft} Cubic meters left.");
            }
        }
    }
}
