﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.NetherRealms
{
    class Demon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Health} health, {Damage:F2} damage";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<Demon> demons = new List<Demon>();
            string healthPattern = @"[^0-9+\-,*/.]";
            string damagePattern = @"([-+]?[0-9]*\.?[0-9]+)";
            string multiplyAndDividePattern = @"[^*/]";

            for (int i = 0; i < input.Length; i++)
            {
                int health = 0;
                MatchCollection letters = Regex.Matches(input[i], healthPattern);
                MatchCollection digits = Regex.Matches(input[i], damagePattern);
                string symbols = Regex.Replace(input[i], multiplyAndDividePattern, "");
                double damage = digits.Sum(x => double.Parse(x.Value));
                double result = CalculateDamage(symbols, damage);

                foreach (Match item in letters)
                {
                    char currentChar = char.Parse(item.ToString());
                    health += (int)currentChar;
                }
                Demon demon = new Demon();
                demon.Name = input[i]; demon.Health = health; demon.Damage = result;
                demons.Add(demon);
            }
            foreach (var demon in demons.OrderBy(x => x.Name))
            {
                Console.WriteLine(demon);
            }
        }

        private static double CalculateDamage(string symbols, double damage)
        {
            foreach (char symbol in symbols)
            {
                damage = symbol == '*' ? damage *= 2 : damage /= 2;
            }
            return damage;
        }
    }
}