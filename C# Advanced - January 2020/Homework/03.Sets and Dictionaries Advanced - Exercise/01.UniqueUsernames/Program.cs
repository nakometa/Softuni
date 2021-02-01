using System;
using System.Collections.Generic;

namespace _01.UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> uniqueNames = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string currentName = Console.ReadLine();
                uniqueNames.Add(currentName);
            }

            Console.WriteLine(String.Join($"{Environment.NewLine}",uniqueNames));
        }
    }
}
