using System;

namespace _09.CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thridLetter = char.Parse(Console.ReadLine());
            //
            Console.WriteLine($"{firstLetter}{secondLetter}{thridLetter}");
        }
    }
}
