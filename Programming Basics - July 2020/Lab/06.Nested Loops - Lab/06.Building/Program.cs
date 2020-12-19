using System;

namespace _06.Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int floor = floors; floor >= 1; floor--)
            {
                for (int room = 0; room < rooms; room++)
                {
                    if (floor == floors)
                    {
                        Console.Write($"L{floor}{room} ");
                    }
                    if (floor % 2 == 0 && floor != floors)
                    {
                        Console.Write($"O{floor}{room} ");
                    }
                    else if (floor % 2 != 0 && floor != floors)
                    {
                        Console.Write($"A{floor}{room} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
