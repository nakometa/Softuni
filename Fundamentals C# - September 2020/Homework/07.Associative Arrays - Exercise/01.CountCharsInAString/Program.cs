using System;
using System.Collections.Generic;

namespace _01.CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Dictionary<char, int> chars = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char[] currentChars = input[i].ToCharArray();
                for (int j = 0; j < input[i].Length; j++)
                {
                    if (chars.ContainsKey(currentChars[j]))
                    {
                        chars[currentChars[j]]++;
                    }
                    else
                    {
                        chars.Add(currentChars[j], 1);
                    }
                }
            }

            foreach (var item in chars)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
