using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PredicateParty_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Dictionary<string, int> guestList = new Dictionary<string, int>();
            Func<string, string, bool> startsWith = (name, part) => name.StartsWith(part);
            Func<string, string, bool> endsWith = (name, part) => name.EndsWith(part);
            Func<string, int, bool> checkLength = (name, part) => name.Length == part;

            foreach (var guest in input)
            {
                guestList.Add(guest, 1);
            }
            string[] cmdArgs = Console.ReadLine().Split();

            while (cmdArgs[0] != "Party!" && guestList.Count > 0)
            {
                string part = cmdArgs[2];
                if (cmdArgs[0] == "Remove")
                {
                    switch (cmdArgs[1])
                    {
                        case "StartsWith":
                            guestList = guestList.Where(x => !startsWith(x.Key, part)).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
                            break;
                        case "EndsWith":
                            guestList = guestList.Where(x => !endsWith(x.Key, part)).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
                            break;
                        case "Length":
                            int length = int.Parse(part);
                            guestList = guestList.Where(x => !checkLength(x.Key, length)).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
                            break;
                    }
                }
                else
                {
                    string[] tempArr = new string[] { };
                    switch (cmdArgs[1])
                    {
                        case "StartsWith":
                            tempArr = guestList.Where(x => startsWith(x.Key, part)).Select(x => x.Key).ToArray();
                            break;
                        case "EndsWith":
                            tempArr = guestList.Where(x => endsWith(x.Key, part)).Select(x => x.Key).ToArray();
                            break;
                        case "Length":
                            int length = int.Parse(part);
                            tempArr = guestList.Where(x => checkLength(x.Key, length)).Select(x => x.Key).ToArray();
                            break;
                    }
                    foreach (var item in tempArr)
                    {
                        guestList[item] *= 2;
                    }
                    ;
                }
                cmdArgs = Console.ReadLine().Split();
            }

            if (guestList.Count <= 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                List<string> finalList = new List<string>();
                foreach (var item in guestList)
                {
                    for (int i = 0; i < item.Value; i++)
                    {
                        finalList.Add(item.Key);
                    }
                }
                Console.WriteLine(String.Join(", ",finalList) + " are going to the party!");
            }
        }
    }
}
