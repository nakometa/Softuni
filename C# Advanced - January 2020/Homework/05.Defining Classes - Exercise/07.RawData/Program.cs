using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();
                Tire tire1 = new Tire(double.Parse(data[5]), int.Parse(data[6]));
                Tire tire2 = new Tire(double.Parse(data[7]), int.Parse(data[8]));
                Tire tire3 = new Tire(double.Parse(data[9]), int.Parse(data[10]));
                Tire tire4 = new Tire(double.Parse(data[11]), int.Parse(data[12]));
                Car car = new Car(data[0], int.Parse(data[1]), int.Parse(data[2]), int.Parse(data[3]), data[4], tire1, tire2, tire3, tire4);
                cars.Add(car);
            }
            string filter = Console.ReadLine();

            if (filter == "fragile")
            {
                cars = cars.Where(c => c.Cargo.CargoType == "fragile" && c.Tires.Any(p => p.Pressure < 1)).ToList();
            }
            else
            {
                cars = cars.Where(c => c.Cargo.CargoType == "flamable" && c.Engine.EnginePower > 250).ToList();
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}
