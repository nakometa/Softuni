using System;

namespace _03.Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyStack<string> customStack = new MyStack<string>();
            string[] cmdArgs = Console.ReadLine().Split(new string[] { " ", ","}, StringSplitOptions.RemoveEmptyEntries);

            while (cmdArgs[0] != "END")
            {
                switch (cmdArgs[0])
                {
                    case "Push":
                        for (int i = 1; i < cmdArgs.Length; i++)
                        {
                            customStack.Push(cmdArgs[i]);
                        }
                        break;
                    case "Pop":
                        try
                        {
                            customStack.Pop();
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.Message);
                        }
                        break;
                }
                cmdArgs = Console.ReadLine().Split();
            }

            foreach (var item in customStack)
            {
                Console.WriteLine(item);
            }

            foreach (var item in customStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
