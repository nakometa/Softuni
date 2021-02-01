using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> elements = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                foreach (var item in input)
                {
                    elements.Add(item);
                }
            }

            Console.WriteLine(String.Join(" ", elements.OrderBy(x => x)));
        }
    }
}
