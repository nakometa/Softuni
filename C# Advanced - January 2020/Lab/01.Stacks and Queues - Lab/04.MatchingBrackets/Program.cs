using System;
using System.Collections.Generic;

namespace _04.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> expressions = new Stack<int>();


            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    expressions.Push(i);
                }
                else if (input[i] == ')')
                {
                    int startIndex = expressions.Pop();
                    string expression = input.Substring(startIndex, i - startIndex + 1);
                    Console.WriteLine(expression);
                }
            }
        }
    }
}
