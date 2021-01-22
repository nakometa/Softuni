using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cmdArgs = Console.ReadLine().Split();
            List<Catalogue> vehicles = new List<Catalogue>();

            while (cmdArgs[0] != "End")
            {
                Catalogue currentVehicle = new Catalogue(cmdArgs[0], cmdArgs[1], cmdArgs[2], int.Parse(cmdArgs[3]));
                vehicles.Add(currentVehicle);
                cmdArgs = Console.ReadLine().Split();
            }

            string model = Console.ReadLine();

            while (model != "Close the Catalogue")
            {
                int vehicleIndex = vehicles.FindIndex(x => x.Model == model);
                Console.WriteLine($"Type: {vehicles[vehicleIndex].Type}");
                Console.WriteLine($"Model: {vehicles[vehicleIndex].Model}");
                Console.WriteLine($"Color: {vehicles[vehicleIndex].Color}");
                Console.WriteLine($"Horsepower: {vehicles[vehicleIndex].Horsepower}");
                model = Console.ReadLine();
            }
            List<Catalogue> cars = new List<Catalogue>(vehicles.Where(x => x.Type == "Car"));
            List<Catalogue> trucks = new List<Catalogue>(vehicles.Where(x => x.Type == "Truck"));

            double carsHorsePower = cars.Sum(x => x.Horsepower);
            double trucksHorsePower = trucks.Sum(x => x.Horsepower);
            double carsAvgHorsePower = 0;
            double trucksAvgHorsePower = 0;

            if (cars.Count > 0)
            {
                carsAvgHorsePower = carsHorsePower / cars.Count;
            }
            if (trucks.Count > 0)
            {
                trucksAvgHorsePower = trucksHorsePower / trucks.Count;
            }

            Console.WriteLine($"Cars have average horsepower of: {carsAvgHorsePower:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAvgHorsePower:F2}.");
        }
    }

    class Catalogue
    {
        public Catalogue(string type, string model, string color, int horsepower)
        {
            type = (type == "car" ? "Car" : "Truck");
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }
    }
}