using System;

namespace BoxOfT
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();
            box.Add("kir");
            box.Add("kir1");
            box.Add("kir2");
            Console.WriteLine(box.Remove());
        }
    }
}
