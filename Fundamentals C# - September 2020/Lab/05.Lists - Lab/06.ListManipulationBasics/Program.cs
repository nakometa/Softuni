using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                            .Split(" ")
                            .Select(int.Parse)
                            .ToList();
            //
            string[] command = Console.ReadLine()
                                       .ToLower()
                                      .Split(" ");

            while (command[0] != "end")
            {
                int num = int.Parse(command[1]);

                switch (command[0])
                {
                    case "add":
                        numbers.Add(num);
                        break;
                    case "remove":
                        numbers.Remove(num);
                        break;
                    case "removeat":
                        numbers.RemoveAt(num);
                        break;
                    case "insert":
                        int index = int.Parse(command[2]);
                        numbers.Insert(index, num);
                        break;
                }
                command = Console.ReadLine()
                                  .ToLower()
                                 .Split(" ");
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
