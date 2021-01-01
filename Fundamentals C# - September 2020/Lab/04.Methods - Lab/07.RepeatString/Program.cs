using System;
using System.Text;

namespace _07.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int repeats = int.Parse(Console.ReadLine());
            Repeats(text, repeats);
        }

        static void Repeats(string text, int repeats)
        {
            StringBuilder texts = new StringBuilder(text);
            for (int i = 0; i < repeats - 1; i++)
            {
                texts = new StringBuilder(texts + text);
            }
            Console.WriteLine(texts);
        }
    }
}
