using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, SortedSet<string>>> app = new Dictionary<string, Dictionary<string,SortedSet<string>>>();
            string[] cmdArgs = Console.ReadLine().Split();

            while (cmdArgs[0] != "Statistics")
            {
                string vlogger = cmdArgs[0];
                string command = cmdArgs[1];

                if (command == "joined")
                {
                    if (!app.ContainsKey(vlogger))
                    {
                        app.Add(vlogger, new Dictionary<string, SortedSet<string>>());
                        app[vlogger].Add("followers", new SortedSet<string>());
                        app[vlogger].Add("following", new SortedSet<string>());
                    }
                }
                else
                {
                    string secondVlogger = cmdArgs[2];
                    if (app.ContainsKey(vlogger) && app.ContainsKey(secondVlogger) && vlogger != secondVlogger)
                    {
                        app[vlogger]["following"].Add(secondVlogger);
                        app[secondVlogger]["followers"].Add(vlogger);
                    }
                }
                cmdArgs = Console.ReadLine().Split();
            }
            int counter = 0;

            Console.WriteLine($"The V-Logger has a total of {app.Count} vloggers in its logs.");
            foreach (var vlogger in app.OrderByDescending(x => x.Value["followers"].Count()).ThenBy(x => x.Value["following"].Count()))
            {
                Console.WriteLine($"{++counter}. {vlogger.Key} : {vlogger.Value["followers"].Count()} followers, {vlogger.Value["following"].Count()} following");
                if (counter == 1)
                {
                    foreach (var item in vlogger.Value["followers"])
                    {
                        Console.WriteLine($"*  {item}");
                    }
                }
            }
        }
    }
}
