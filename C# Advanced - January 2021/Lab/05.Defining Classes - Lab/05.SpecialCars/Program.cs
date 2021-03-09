using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Dictionary<int, List<Tire>> tires = new Dictionary<int, List<Tire>>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();
            int index = 0;

            while (input[0] != "No")
            {
                tires.Add(index, new List<Tire>());
                for (int i = 0; i < 8; i+=2)
                {
                    int year = int.Parse(input[i]);
                    double pressure = double.Parse(input[i + 1]);
                    Tire currentTire = new Tire(year, pressure);
                    tires[index].Add(currentTire);
                }
                input = Console.ReadLine().Split();
                index++;
            }
            input = Console.ReadLine().Split();

            while (input[0] != "Engines")
            {
                int horsePower = int.Parse(input[0]);
                double cubicCapacity = double.Parse(input[1]);
                Engine currentEngine = new Engine(horsePower, cubicCapacity);
                engines.Add(currentEngine);
                input = Console.ReadLine().Split();
            }

            input = Console.ReadLine().Split();

            while (input[0] != "Show")
            {
                string make = input[0];
                string model = input[1];
                int year = int.Parse(input[2]);
                double fuelQuantity = double.Parse(input[3]);
                double fuelConsumption = double.Parse(input[4]);
                int engineIndex = int.Parse(input[5]);
                int tireIndex = int.Parse(input[6]);
                Car currentCar = new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tireIndex]);
                cars.Add(currentCar);
                input = Console.ReadLine().Split();
            }

            foreach (Car car in cars)
            {
                if (car.Engine.HorsePower > 330 && car.Year >= 2017 && car.Tires.Sum(x => x.Pressure) >= 9 && car.Tires.Sum(x => x.Pressure)  <= 10)
                {
                    car.Drive(20);
                    Console.WriteLine(car.WhoAmI());
                }
            }
        }
    }
}
