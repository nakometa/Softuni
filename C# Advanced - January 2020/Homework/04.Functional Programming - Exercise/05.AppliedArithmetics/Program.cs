using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            Func<int, int> func = num => num;
            string[] cmdArgs = Console.ReadLine().Split();
            Action<List<int>> print = nums => Console.WriteLine(String.Join(" ", nums)); 

            while (cmdArgs[0] != "end")
            {
                if (cmdArgs[0] == "add")
                {
                    func = num => num + 1;
                    numbers = numbers.Select(func).ToList();
                }
                else if (cmdArgs[0] == "multiply")
                {
                    func = num => num * 2;
                    numbers = numbers.Select(func).ToList();
                }
                else if (cmdArgs[0] == "subtract")
                {
                    func = num => num - 1;
                    numbers = numbers.Select(func).ToList();
                }
                else if (cmdArgs[0] == "print")
                {
                    print(numbers);
                }
                cmdArgs = Console.ReadLine().Split();
            }
        }
    }
}
