using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = data[0];
                string power = data[1];
                Engine currEngine;

                if (data.Count() == 2)
                {
                    currEngine = new Engine(model, power);
                }
                else if (data.Count() == 3)
                {
                    //currEngine = new Engine(model, power, data[2]);
                    int temp;
                    bool isNum = int.TryParse(data[2], out temp);
                    if (isNum)
                    {
                        currEngine = new Engine(model, power, data[2], "n/a");
                    }
                    else
                    {
                        currEngine = new Engine(model, power, "n/a", data[2]);
                    }
                }
                else
                {
                    currEngine = new Engine(model, power, data[2], data[3]);
                }
                engines.Add(currEngine);
            }
            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = data[0];
                string engine = data[1];
                Car currCar;

                if (data.Count() == 2)
                {
                    currCar = new Car(model, engines.FirstOrDefault(e => e.Model == engine));
                }
                else if (data.Count() == 3)
                {
                    //currCar = new Car(model, engines.FirstOrDefault(e => e.Model == engine), data[2]);
                    int temp;
                    bool isNum = int.TryParse(data[2], out temp);
                    if (isNum)
                    {
                        currCar = new Car(model, engines.FirstOrDefault(e => e.Model == engine), data[2], "n/a");
                    }
                    else
                    {
                        currCar = new Car(model, engines.FirstOrDefault(e => e.Model == engine), "n/a", data[2]);
                    }
                }
                else
                {
                    currCar = new Car(model, engines.FirstOrDefault(e => e.Model == engine), data[2], data[3]);
                }
                cars.Add(currCar);
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
