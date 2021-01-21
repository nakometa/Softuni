using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
    .Split('|')
    .Reverse()
    .ToList();

            List<string> result = new List<string>();

            foreach (var item in numbers)
            {
                string[] arrNums = item.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                foreach (var num in arrNums)
                {
                    result.Add(num);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
