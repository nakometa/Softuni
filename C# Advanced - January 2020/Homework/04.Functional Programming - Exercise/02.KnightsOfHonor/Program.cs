using System;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            for (int i = 0; i < input.Length; i++)
            {
                string currentName = input[i];
                Action<string> printName = x => Console.WriteLine($"Sir {x}");
                printName(currentName);
            }
        }
    }
}
