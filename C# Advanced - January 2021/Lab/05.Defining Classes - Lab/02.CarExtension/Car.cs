using System;
using System.Collections.Generic;
using System.Text;

namespace _02.CarExtension
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public void Drive(double distance)
        {
            double requiredFuel = FuelQuantity - distance * FuelConsumption;
            if (requiredFuel >= 0)
            {
                FuelQuantity -= requiredFuel;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            return $"Make: { this.Make}\nModel: { this.Model}\nYear: { this.Year}\nFuel: { this.FuelQuantity:F2}L";
        }
    }
}
