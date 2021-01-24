using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> integers = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split();

                switch (cmdArgs[0])
                {
                    case "1":
                        integers.Push(int.Parse(cmdArgs[1]));
                        break;
                    case "2":
                        if (integers.Any())
                        {
                            integers.Pop();
                        }
                        break;
                    case "3":
                        if (integers.Any())
                        {
                            Console.WriteLine(integers.Max());
                        }
                        break;
                    case "4":
                        if (integers.Any())
                        {
                            Console.WriteLine(integers.Min());
                        }
                        break;
                }
            }
            Console.WriteLine(String.Join(", ", integers));
        }
    }
}
