﻿using System;

namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] strings = ArrayCreator.Create(5, "Nako");
            Console.WriteLine(String.Join(" ", strings));
        }
    }
}
