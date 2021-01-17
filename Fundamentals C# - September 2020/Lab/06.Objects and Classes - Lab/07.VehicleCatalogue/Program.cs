using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vehicle = Console.ReadLine().Split("/");
            Catalog catalog = new Catalog();

            while (vehicle[0] != "end")
            {
                if (vehicle[0] == "Car")
                {
                    string brand = vehicle[1];
                    string model = vehicle[2];
                    string horsePower = vehicle[3];

                    Car car = new Car();
                    car.Brand = brand;
                    car.Model = model;
                    car.HorsePower = horsePower;
                    catalog.Cars.Add(car);
                }
                else
                {
                    string brand = vehicle[1];
                    string model = vehicle[2];
                    string weight = vehicle[3];

                    Truck truck = new Truck();
                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = weight;
                    catalog.Trucks.Add(truck);
                }
                vehicle = Console.ReadLine().Split("/");
            }

            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (var car in catalog.Cars.OrderBy(car => car.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in catalog.Trucks.OrderBy(truck => truck.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }

    class Car
        {
            public string Brand { get; set; }

            public string Model { get; set; }

            public string HorsePower { get; set; }
        }

        class Truck
        {
            public string Brand { get; set; }

            public string Model { get; set; }

            public string Weight { get; set; }
        }

        class Catalog
        {
            public List<Car> Cars { get; set; }
            public List<Truck> Trucks { get; set; }


            public Catalog() // инициализация на Cars и Trucks листовете в конструктора
            {
                Cars = new List<Car>();

                Trucks = new List<Truck>();
            }
        }
}
