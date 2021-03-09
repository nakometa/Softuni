using System;
using System.Collections.Generic;
using System.Text;

namespace _08.CarSalesman
{
    public class Car
    {
        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
            Weight = "n/a";
            Color = "n/a";
        }

        public Car(string model, Engine engine, string color)
            : this(model, engine)
        {
            Color = color;
        }

        public Car(string model, Engine engine, string weight, string color)
            : this (model, engine, weight)
        {
            Weight = weight;
            Color = color;
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public string Weight { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            string res = $"{this.Model}:\n {this.Engine.Model}:\n  Power: {this.Engine.Power}\n  Displacement: {this.Engine.Displacement}\n  Efficiency: {this.Engine.Efficiency}\n Weight: {this.Weight}\n Color: {this.Color}";
            return res;
        }
    }
}
