using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ListyIterator
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().Skip(1).ToList();
            ListyIterator<string> list = new ListyIterator<string>(input);

            string[] command = Console.ReadLine().Split();

            while (command[0] != "END")
            {
                switch (command[0])
                {
                    case "Move":
                        Console.WriteLine(list.Move());
                        break;
                    case "Print":
                        try
                        {
                            list.Print();
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "HasNext":
                        Console.WriteLine(list.HasNext());
                        break;
                }
                command = Console.ReadLine().Split();
            }
        }
    }
}
