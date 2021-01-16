using System;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z]{1}[a-z]+ \b[A-Z]{1}[a-z]+";
            string names = Console.ReadLine();

            MatchCollection matchedNames = Regex.Matches(names, pattern);

            foreach (Match name in matchedNames)
            {
                Console.Write(name.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
