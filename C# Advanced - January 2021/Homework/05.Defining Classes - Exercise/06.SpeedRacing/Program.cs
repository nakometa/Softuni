using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SpeedRacing
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
                string model = data[0];
                double fuelAmount = double.Parse(data[1]);
                double fuelConsumptionPerKm = double.Parse(data[2]);
                Car currCar = new Car(model, fuelAmount, fuelConsumptionPerKm);
                cars.Add(currCar);
            }
            string[] cmdArgs = Console.ReadLine().Split();

            while (cmdArgs[0] != "End")
            {
                string carModel = cmdArgs[1];
                Car currcar = cars.Where(n => n.Model == carModel).FirstOrDefault();
                double kilometers = double.Parse(cmdArgs[2]);
                currcar.Drive(currcar, kilometers);
                cmdArgs = Console.ReadLine().Split();
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }
        }
    }
}
