using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<string> customers = new Queue<string>();

            while (input != "End")
            {
                if (input != "Paid")
                {
                    customers.Enqueue(input);
                }
                else
                {
                    int amountOfCustomers = customers.Count();
                    for (int i = 0; i < amountOfCustomers; i++)
                    {
                        Console.WriteLine(customers.Dequeue());
                    }

                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{customers.Count} people remaining.");
        }
    }
}
