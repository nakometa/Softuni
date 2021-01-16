using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"[+359]{4}( |-)2\1[0-9]{3}\1[0-9]{4}\b";
            var phones = Console.ReadLine();
            var matchPhones = Regex.Matches(phones, pattern);

            var matchedPhones = matchPhones.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(String.Join(", ", matchedPhones));
        }
    }
}
