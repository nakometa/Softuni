using System;
using System.Linq;

namespace _03.Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] firstArr = new string[n];
            string[] secondArr = new string[n];
            //
            for (int i = 0; i < n; i++)
            {
                string[] currentArray = Console.ReadLine()
                                              .Split(" ")
                                              .ToArray();
                if (i % 2 == 0)
                {
                    firstArr[i] = currentArray[0];
                    secondArr[i] = currentArray[1];
                }
                else if (i % 2 == 1)
                {
                    firstArr[i] = currentArray[1];
                    secondArr[i] = currentArray[0];
                }
            }
            Console.WriteLine(string.Join(" ", firstArr));
            Console.WriteLine(string.Join(" ", secondArr));
        }
    }
}
