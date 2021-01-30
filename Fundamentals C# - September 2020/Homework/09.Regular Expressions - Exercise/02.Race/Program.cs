using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Dictionary<string, int> racers = new Dictionary<string, int>();
            string namePattern = @"([A-Za-z]+)";
            string distancePattern = @"([0-9])";

            foreach (var racer in input)
            {
                racers.Add(racer, 0);
            }

            string regex = Console.ReadLine();

            while (regex != "end of race")
            {
                var nameMatches = Regex.Matches(regex, namePattern);
                var distanceMatches = Regex.Matches(regex, distancePattern);
                var name = string.Empty;
                var distance = 0;

                foreach (Match str in nameMatches)
                {
                    name += str;
                }
                foreach (Match digit in distanceMatches)
                {
                    distance += int.Parse(digit.ToString());
                }

                if (racers.ContainsKey(name))
                {
                    racers[name] += distance;
                }

                regex = Console.ReadLine();
            }
            int count = 1;

            foreach (var racer in racers.OrderByDescending(x => x.Value))
            {
                string text = count == 1 ? "st" : count == 2 ? "nd" : "rd";

                Console.WriteLine($"{count++}{text} place: {racer.Key}");

                if (count == 4)
                {
                    break;
                }
            }
        }
    }
}
