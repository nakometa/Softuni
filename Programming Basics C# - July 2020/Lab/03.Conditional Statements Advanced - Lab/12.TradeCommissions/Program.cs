using System;

namespace _12.TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            double comission = 0;

            switch (town)
            {
                case "Sofia":
                    if (sales <= 500 && sales > 0)
                    {
                        comission = 0.05;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        comission = 0.07;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        comission = 0.08;
                    }
                    else if (sales > 10000)
                    {
                        comission = 0.12;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Varna":
                    if (sales <= 500 && sales > 0)
                    {
                        comission = 0.045;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        comission = 0.075;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        comission = 0.1;
                    }
                    else if (sales > 10000)
                    {
                        comission = 0.13;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Plovdiv":
                    if (sales <= 500 && sales > 0)
                    {
                        comission = 0.055;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        comission = 0.08;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        comission = 0.12;
                    }
                    else if (sales > 10000)
                    {
                        comission = 0.145;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
            double comissionCost = comission * sales;

            if (comissionCost > 0)
            {
                Console.WriteLine($"{comissionCost:F2}");
            }
        }
    }
}
