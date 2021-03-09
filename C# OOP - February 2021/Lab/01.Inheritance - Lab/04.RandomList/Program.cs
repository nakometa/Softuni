using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList newList = new RandomList();
            newList.Add("Nako");
            newList.Add("Zed");
            newList.Add("karata");
            newList.Add("krisko");
            newList.Add("pesho");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(newList.RandomString());
            }
        }
    }
}
