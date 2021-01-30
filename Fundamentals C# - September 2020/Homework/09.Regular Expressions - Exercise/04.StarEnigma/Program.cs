﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string starPattern = @"[STARstar]";
            string planetPattern = @"[^@\-!:>]*?\@([A-Za-z]+)[^@\-!:>]*?:([0-9]+)[^@\-!:>]*?!(A|D)![^@\-!:>]*->([0-9]+)[^@\-!:>]*";
            Dictionary<string, string> planets = new Dictionary<string, string>();

            for (int i = 0; i < num; i++)
            {
                string key = Console.ReadLine();
                MatchCollection matches = Regex.Matches(key, starPattern);
                StringBuilder sb = new StringBuilder();
                int value = matches.Count();
                foreach (char ch in key)
                {
                    int currentChar = ch - value;
                    sb.Append((char)currentChar);
                }
                Match planetInfo = Regex.Match(sb.ToString(), planetPattern);
                if (planetInfo.Success)
                {
                    string planetName = planetInfo.Groups[1].Value;
                    string planetType = planetInfo.Groups[3].Value;
                    planets.Add(planetName, planetType);
                }
            }

            Console.WriteLine($"Attacked planets: {planets.Where(x => x.Value == "A").Count()}");
            foreach (var planet in planets.Where(x => x.Value == "A").OrderBy(x => x.Key))
            {
                Console.WriteLine($"-> {planet.Key}");
            }
            Console.WriteLine($"Destroyed planets: {planets.Where(x => x.Value == "D").Count()}");
            foreach (var planet in planets.Where(x => x.Value == "D").OrderBy(x => x.Key))
            {
                Console.WriteLine($"-> {planet.Key}");
            }
        }
    }
}
