using System;
using System.Collections.Generic;
using System.Text;

namespace _08.CarSalesman
{
    public class Engine
    {
        public Engine(string model, string power)
        {
            Model = model;
            Power = power;
            Displacement = "n/a";
            Efficiency = "n/a";
        }

        public Engine(string model, string power, string displacement)
            : this(model, power)
        {
            Displacement = displacement;
        }

        public Engine(string model, string power, string displacement, string efficiency)
            : this (model, power, displacement)
        {
            Efficiency = efficiency;
        }

        public string Model { get; set; }
        public string Power { get; set; }
        public string Displacement { get; set; }
        public string Efficiency { get; set; }
    }
}
