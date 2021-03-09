using System;
using System.Collections.Generic;

namespace _06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ");
            HashSet<string> numbers = new HashSet<string>();

            while (input[0] != "END")
            {
                string command = input[0];
                string number = input[1];

                if (command == "IN")
                {
                    numbers.Add(number);
                }
                else
                {
                    numbers.Remove(number);
                }
                input = Console.ReadLine().Split(", ");
            }

            if (numbers.Count > 0)
            {
                foreach (var item in numbers)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
