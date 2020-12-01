using System;

namespace _04.VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int pagesNumber = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            int readingDays = int.Parse(Console.ReadLine());

            double totalBookReadingTime = pagesNumber / pagesPerHour;
            double readingTimePerDay = totalBookReadingTime / readingDays;

            Console.WriteLine(readingTimePerDay);
        }
    }
}
