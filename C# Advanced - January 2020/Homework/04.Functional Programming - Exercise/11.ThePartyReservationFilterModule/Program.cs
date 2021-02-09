using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.ThePartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inviteList = Console.ReadLine().Split().ToList();
            List<string> filters = new List<string>();
            string[] cmdArgs = Console.ReadLine().Split(";");

            while (cmdArgs[0] != "Print")
            {
                string currentFilter = cmdArgs[1] + $" {cmdArgs[2]}";

                if (cmdArgs[0] == "Add filter")
                {
                    filters.Add(currentFilter);
                }
                else if (cmdArgs[0] == "Remove filter")
                {
                    filters.Remove(currentFilter);
                }
                cmdArgs = Console.ReadLine().Split(";");
            }

            foreach (var filterArg in filters)
            {
                string[] filterSplit = filterArg.Split();
                string part;

                if (filterArg.Contains("Starts with"))
                {
                    part = filterSplit[2];
                    Func<string, string, bool> startsFunc = (guest, part) => guest.StartsWith(part);
                    inviteList = inviteList.Where(g => !startsFunc(g, part)).ToList();
                }
                else if (filterArg.Contains("Ends with"))
                {
                    part = filterSplit[2];
                    Func<string, string, bool> endsFunc = (guest, part) => guest.EndsWith(part);
                    inviteList = inviteList.Where(g => !endsFunc(g, part)).ToList();
                }
                else if (filterArg.Contains("Length"))
                {
                    part = filterSplit[1];
                    int length = int.Parse(part);
                    Func<string, int, bool> lengthFunc = (guest, length) => guest.Length == length;
                    inviteList = inviteList.Where(g => !lengthFunc(g, length)).ToList();
                }
                else
                {
                    part = filterSplit[1];
                    Func<string, string, bool> containsFunc = (guest, part) => guest.Contains(part);
                    inviteList = inviteList.Where(g => !containsFunc(g, part)).ToList();
                }
            }

            Console.WriteLine(String.Join(" ", inviteList));
        }
    }
}
