using System;

namespace _01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string reverseWord = string.Empty;
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reverseWord += input[i];
                }
                Console.WriteLine($"{input} = {reverseWord}");

                input = Console.ReadLine();
            }
        }
    }
}
