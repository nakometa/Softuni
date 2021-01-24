using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sb = new StringBuilder();
            Stack<string> previousText = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split();
                switch (cmdArgs[0])
                {
                    case "1":
                        previousText.Push(sb.ToString());
                        sb.Append(cmdArgs[1]);
                        break;
                    case "2":
                        previousText.Push(sb.ToString());
                        sb.Remove(sb.Length - int.Parse(cmdArgs[1]), int.Parse(cmdArgs[1]));
                        break;
                    case "3":
                        int index = int.Parse(cmdArgs[1]) - 1;
                        Console.WriteLine(sb[index]);
                        break;
                    case "4":
                        sb.Clear();
                        sb.Append(previousText.Pop());
                        break;
                }
            }
        }
    }
}
