using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> parentheses = new Stack<char>();
            bool success = true;

            foreach (char item in input)
            {
                if (item == '(' || item == '{' || item == '[')
                {
                    parentheses.Push(item);
                }
                else 
                {
                    if (parentheses.Count == 0)
                    {
                        success = false;
                        break;
                    }
                    bool check1 = item == ')' && parentheses.Pop() == '(';
                    bool check2 = item == '}' && parentheses.Pop() == '{';
                    bool check3 = item == ']' && parentheses.Pop() == '[';

                    if (!check1 && !check2 && !check3)
                    {
                        success = false;
                        break;
                    }
                }
            }

            if (success)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
