using System;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourceList = new Dictionary<string, int>();
            string resource = Console.ReadLine();

            while (resource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (resourceList.ContainsKey(resource))
                {
                    resourceList[resource] += quantity;
                }
                else
                {
                    resourceList.Add(resource, quantity);
                }
                resource = Console.ReadLine();
            }

            foreach (var item in resourceList)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
