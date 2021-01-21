using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();
            string[] command = Console.ReadLine().ToLower().Split();

            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "add":
                        numbers.Add(int.Parse(command[1]));
                        break;
                    case "insert":
                        int index = int.Parse(command[2]);
                        if (isInRange(index, numbers.Count))
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers.Insert(index, int.Parse(command[1]));
                        }
                        break;
                    case "remove":
                        int indexRemove = int.Parse(command[1]);
                        if (isInRange(indexRemove, numbers.Count))
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers.RemoveAt(indexRemove);
                        }
                        break;
                    case "shift":
                        int rotations = int.Parse(command[2]);
                        if (command[1] == "left")
                        {
                            for (int i = 0; i < rotations; i++)
                            {
                                int firstNum = numbers[0];

                                for (int j = 0; j < numbers.Count - 1; j++)
                                {
                                    numbers[j] = numbers[j + 1];
                                }
                                numbers[numbers.Count - 1] = firstNum;
                            }
                        }
                        else
                        {
                            for (int i = 0; i < rotations; i++)
                            {
                                int firstNum = numbers[numbers.Count - 1];
                                for (int j = numbers.Count - 1; j > 0; j--)
                                {
                                    numbers[j] = numbers[j - 1];
                                }
                                numbers[0] = firstNum;
                            }
                        }
                        break;
                }
                command = Console.ReadLine().ToLower().Split();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        public static bool isInRange(int index, int count)
        {
            return index < 0 || index > count;
        }
    }
}