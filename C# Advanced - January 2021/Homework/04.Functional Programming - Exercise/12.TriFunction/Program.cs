using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();
            Func<string, int, bool> check = (name, n) =>
            {
                int nameSum = 0;
                foreach (char ch in name)
                {
                    nameSum += ch;
                }
                return nameSum >= n;
            };
            Func<List<string>, int, Func<string, int, bool>, string> func = (names, n, check) =>
             {
                 string match = string.Empty;
                 foreach (var name in names)
                 {
                     if (check(name, n))
                     {
                         match = name;
                         break;
                     }
                 }
                 return match;
             };
            string matchingName = func(names, n, check);

            Action<string> print = str => Console.WriteLine(str);
            print(matchingName);
        }
    }
}
