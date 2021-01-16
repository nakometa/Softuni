using System;
using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})([.\-\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            string input = Console.ReadLine();
            var dates = Regex.Matches(input, pattern);

            foreach (Match date in dates)
            {
                Console.WriteLine($"Day: {date.Groups["day"].Value}, Month: {date.Groups["month"].Value}, Year: {date.Groups["year"].Value}");
            }
        }
    }
}
