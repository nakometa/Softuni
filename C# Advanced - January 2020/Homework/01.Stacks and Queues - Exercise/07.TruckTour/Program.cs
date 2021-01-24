using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int> petrol = new Queue<int>();
            Queue<int> distance = new Queue<int>();
            int index = 0;
            int currentPetrol = 0;
            int currentDistance = 0;

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                petrol.Enqueue(input[0]);
                distance.Enqueue(input[1]);
            }

            for (int i = 0; i < n; i++)
            {
                int currentFuel = 0;
                bool isSuccess = true;
                for (int j = 0; j < n; j++)
                {
                    int fuel = petrol.Dequeue();
                    int km = distance.Dequeue();
                    petrol.Enqueue(fuel);
                    distance.Enqueue(km);
                    currentFuel += fuel;
                    currentFuel -= km;
                    if (currentFuel < 0)
                    {
                        isSuccess = false;
                    }
                }
                if (isSuccess)
                {
                    index = i;
                    break;
                }
                currentPetrol = petrol.Dequeue();
                currentDistance = distance.Dequeue();
                petrol.Enqueue(currentPetrol);
                distance.Enqueue(currentDistance);
            }
            Console.WriteLine(index);
        }
    }
}
