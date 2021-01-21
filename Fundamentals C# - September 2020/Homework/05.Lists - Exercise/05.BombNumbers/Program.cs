using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                             .Split()
                   .Select(int.Parse)
                            .ToList();

            string[] bombNumberAndPower = Console.ReadLine().Split();
            int power = int.Parse(bombNumberAndPower[1]);
            int bomb = int.Parse(bombNumberAndPower[0]);

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == bomb)
                {
                    int startIndex = numbers.IndexOf(bomb) - power;
                    int endIndex = numbers.IndexOf(bomb) + power;

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex > numbers.Count - 1)
                    {
                        endIndex = numbers.Count - 1;
                    }

                    int endIndexToRemove = endIndex - startIndex + 1;
                    numbers.RemoveRange(startIndex, endIndexToRemove);

                    i = startIndex - 1;
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
