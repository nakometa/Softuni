using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Stack<string> result = new Stack<string>(input);
            string[] cmdArgs = Console.ReadLine().Split();

            while (cmdArgs[0].ToUpper() != "END")
            {
                if (cmdArgs[0].ToUpper() == "ADD")
                {
                    int num1 = int.Parse(cmdArgs[1]);
                    int num2 = int.Parse(cmdArgs[2]);
                    result.Push(num1.ToString());
                    result.Push(num2.ToString());
                }
                else
                {
                    int removeCounter = int.Parse(cmdArgs[1]);
                    if (removeCounter < result.Count)
                    {
                        for (int i = 0; i < removeCounter; i++)
                        {
                            result.Pop();
                        }
                    }
                }
                cmdArgs = Console.ReadLine().Split();
            }

            Console.WriteLine("Sum: " + result.Select(int.Parse).Sum());
        }
    }
}
