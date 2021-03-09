using System;
using System.Collections.Generic;

namespace _08.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int passingCars = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            string input = Console.ReadLine();
            int passedCars = 0;

            while (input != "end")
            {
                if (input == "green")
                {
                    if (cars.Count >= passingCars)
                    {
                        for (int i = 0; i < passingCars; i++)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            passedCars++;
                        }
                    }
                    else
                    {
                        int carsToPass = cars.Count;
                        for (int i = 0; i < carsToPass; i++)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            passedCars++;
                        }
                    }
                }
                else

                {
                    cars.Enqueue(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{passedCars} cars passed the crossroads.");
        }
    }
}
