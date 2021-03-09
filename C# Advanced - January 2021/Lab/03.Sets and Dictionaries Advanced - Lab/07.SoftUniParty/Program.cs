using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            string invited = Console.ReadLine();
            HashSet<string> invitedList = new HashSet<string>();
            HashSet<string> appeared = new HashSet<string>();
            int missingCount = 0;
            HashSet<string> missingGuests = new HashSet<string>();
            HashSet<string> missingVips = new HashSet<string>();

            while (invited != "PARTY")
            {
                invitedList.Add(invited);
                invited = Console.ReadLine();
            }
            string guest = Console.ReadLine();
            while (guest != "END")
            {
                appeared.Add(guest);
                guest = Console.ReadLine();
            }

            
            foreach (var item in invitedList)
            {
                if (!appeared.Contains(item))
                {
                    missingCount++;
                    if (char.IsDigit(item[0]))
                    {
                        missingVips.Add(item);
                    }
                    else
                    {
                        missingGuests.Add(item);
                    }
                }
            }

            Console.WriteLine(missingCount);
            foreach (var item in missingVips)
            {
                Console.WriteLine(item);
            }
            foreach (var item in missingGuests)
            {
                Console.WriteLine(item);
            }
        }
    }
}
