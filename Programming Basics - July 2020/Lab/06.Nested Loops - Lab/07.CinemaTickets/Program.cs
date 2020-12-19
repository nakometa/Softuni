using System;

namespace _07.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int studentTicketsCounter = 0;
            int standardTicketsCounter = 0;
            int kidTicketsCounter = 0;
            int counter = 0;

            while (movie != "Finish")
            {
                int freeSpace = int.Parse(Console.ReadLine());
                string currentTicket = Console.ReadLine();
                int currentFreeSpace = freeSpace;

                while (freeSpace > 0)
                {
                    if (currentTicket == "End")
                    {
                        break;
                    }
                    counter++;
                    switch (currentTicket)
                    {
                        case "student":
                            studentTicketsCounter++;
                            break;
                        case "standard":
                            standardTicketsCounter++;
                            break;
                        case "kid":
                            kidTicketsCounter++;
                            break;
                    }
                    freeSpace--;
                    if (freeSpace == 0)
                    {
                        break;
                    }
                    currentTicket = Console.ReadLine();
                }
                double fullPercent = counter * 1.0;
                Console.WriteLine($"{movie} - {(fullPercent / currentFreeSpace * 1.0) * 100:F2}% full.");
                counter = 0;
                movie = Console.ReadLine();
            }
            int totalTickets = kidTicketsCounter + standardTicketsCounter + studentTicketsCounter;
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentTicketsCounter * 1.0 / totalTickets * 1.0 * 100:F2}% student tickets.");
            Console.WriteLine($"{standardTicketsCounter * 1.0 / totalTickets * 1.0 * 100:F2}% standard tickets.");
            Console.WriteLine($"{kidTicketsCounter * 1.0 / totalTickets * 1.0 * 100:F2}% kids tickets.");
        }
    }
}
