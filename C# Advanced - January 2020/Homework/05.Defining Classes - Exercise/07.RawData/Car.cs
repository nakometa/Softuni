using System;
using System.Collections.Generic;
using System.Text;

namespace _07.RawData
{
    class Car
    {
        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType, Tire tire1, Tire tire2, Tire tire3, Tire tire4)
        {
            this.Model = model;
            Engine = new Engine(engineSpeed,enginePower);
            Cargo = new Cargo(cargoWeight, cargoType);
            Tires = new List<Tire>();
            Tires.Add(tire1);
            Tires.Add(tire2);
            Tires.Add(tire3);
            Tires.Add(tire4);
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public List<Tire> Tires { get; set; }
    }
}
