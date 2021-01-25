using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> pathway = Console.ReadLine().Split(@"\").ToList();
            string lastItem = pathway[pathway.Count - 1];
            string[] lastItems = lastItem.Split(".");

            Console.WriteLine($"File name: {lastItems[0]}");
            Console.WriteLine($"File extension: {lastItems[1]}");
        }
    }
}