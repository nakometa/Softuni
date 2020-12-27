using System;

namespace _01.OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string favBook = Console.ReadLine();
            string currentBook = Console.ReadLine();
            int count = 0;
            bool isFound = false;

            while (currentBook != "No More Books")
            {
                if (currentBook == favBook)
                {
                    isFound = true;
                    break;
                }

                currentBook = Console.ReadLine();
                count++;
            }
            if (isFound == true)
            {
                Console.WriteLine($"You checked {count} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }
        }
    }
}
