using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Engine
    {
        public Engine()
        {

        }
        public Engine(int horsepower, double cubicCapacity)
            : this()
        {
            this.HorsePower = horsepower;
            this.CubicCapacity = cubicCapacity;
        }
        public int HorsePower { get; set; }
        public double CubicCapacity { get; set; }
    }
}
