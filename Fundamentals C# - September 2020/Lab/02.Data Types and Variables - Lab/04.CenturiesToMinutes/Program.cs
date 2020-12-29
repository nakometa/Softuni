using System;

namespace _04.CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double days = n * 36524.22;

            Console.WriteLine($"{n} centuries = {n * 100} years = {(int)days} days = {(int)days * 24} hours = {(int)days * 1440} minutes");
        }
    }
}
