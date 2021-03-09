using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            int[] bulletsInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locksInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int intelligenceValue = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>(bulletsInput);
            Queue<int> locks = new Queue<int>(locksInput);
            int bulletsInsideBarrel = gunBarrelSize;
            int bulletCost = 0;

            while (bullets.Any() && locks.Any())
            {
                int currentBullet = bullets.Pop();
                bulletsInsideBarrel--;
                bulletCost += bulletPrice;

                if (currentBullet <= locks.Peek())
                {
                    locks.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                if (bulletsInsideBarrel == 0 && bullets.Any())
                {
                    Console.WriteLine("Reloading!");
                    bulletsInsideBarrel = gunBarrelSize;
                }
            }

            if (locks.Count() <= 0)
            {
                Console.WriteLine($"{bullets.Count()} bullets left. Earned ${intelligenceValue - bulletCost}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count()}");
            }
        }
    }
}
