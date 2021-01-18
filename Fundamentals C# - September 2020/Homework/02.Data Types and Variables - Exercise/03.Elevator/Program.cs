using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());
            var courses = 0;
            //
            while (people > 0)
            {
                people -= elevatorCapacity;
                courses++;
            }
            Console.WriteLine(courses);
        }
    }
}
