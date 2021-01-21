using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] cmdArgs = Console.ReadLine().Split();

            while (cmdArgs[0] != "end")
            {
                string command = cmdArgs[0];
                string element = cmdArgs[1];

                switch (command)
                {
                    case "Delete":
                        for (int i = 0; i < input.Count; i++)
                        {
                            if (input[i] == int.Parse(element))
                            {
                                input.RemoveAt(i);
                            }
                        }
                        break;
                    case "Insert":
                        input.Insert(int.Parse(cmdArgs[2]), int.Parse(element));
                        break;
                }
                cmdArgs = Console.ReadLine().Split();
            }

            Console.WriteLine(String.Join(" ", input));
        }
    }
}
