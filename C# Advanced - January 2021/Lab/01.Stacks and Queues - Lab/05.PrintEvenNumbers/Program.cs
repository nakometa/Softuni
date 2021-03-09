using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> evenNumbers = new Queue<int>(input);

            for (int i = 0; i < input.Count(); i++)
            {
                int num = evenNumbers.Peek();
                if (num % 2 == 0)
                {
                    if (input.Count() - 1 > i)
                    {
                        Console.Write(evenNumbers.Dequeue() + ", ");
                    }
                    else
                    {
                        Console.Write(evenNumbers.Dequeue());
                    }
                }
                else
                {
                    evenNumbers.Dequeue();
                }
            }
        }
    }
}
