using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _10.CrossRoads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            bool crash = false;
            int carsPassed = 0;

            Queue<string> cars = new Queue<string>();

            while (input != "END")
            {
                int greenTimeLeft = greenLightDuration;
                int freeTimeLeft = freeWindowDuration;
                if (input != "green")
                {
                    cars.Enqueue(input);
                }
                else
                {
                    while (greenTimeLeft > 0 && cars.Any())
                    {
                        string currentCar = cars.Dequeue();
                        carsPassed++;

                        for (int i = 0; i < currentCar.Length; i++)
                        {
                            char currentChar = currentCar[i];
                            if (greenTimeLeft > 0)
                            {
                                greenTimeLeft--;
                            }
                            else
                            {
                                if (freeTimeLeft > 0)
                                {
                                    freeTimeLeft--;
                                }
                                else
                                {
                                    Console.WriteLine($"A crash happened!\n{currentCar} was hit at {currentChar}.");
                                    crash = true;
                                    break;
                                }
                            }
                        }
                        if (crash)
                        {
                            break;
                        }
                    }
                    if (crash)
                    {
                        break;
                    }
                }
                input = Console.ReadLine();
            }

            if (!crash)
            {
                Console.WriteLine($"Everyone is safe.\n{carsPassed} total cars passed the crossroads.");
            }
        }
    }
}
