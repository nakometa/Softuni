using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            while (true)
            {
                string[] comand = Console.ReadLine().Split().ToArray();

                if (comand[0] == "3:1")
                {
                    Console.Write(string.Join(" ", input));
                    break;
                }

                else if (comand[0] == "merge")
                {
                    int startIndex = int.Parse(comand[1]);
                    int endIndex = int.Parse(comand[2]);
                    Merge(input, startIndex, endIndex);
                }
                else if (comand[0] == "divide")
                {
                    int index = int.Parse(comand[1]);
                    int partitions = int.Parse(comand[2]);
                    Divide(input, index, partitions);
                }

            }

        }

        static void Merge(List<string> input, int startIndex, int endIndex)
        {
            if (startIndex < 0)
            {
                startIndex = 0;
            }
            if (endIndex > input.Count - 1)
            {
                endIndex = input.Count - 1;
            }

            for (int j = startIndex + 1; j <= endIndex; j++)
            {
                input[startIndex] += input[startIndex + 1];
                input.RemoveAt(startIndex + 1);
            }
        }

        static void Divide(List<string> input, int index, int partitions)
        {
            string partitionData = input[index];
            input.RemoveAt(index);
            int partSize = partitionData.Length / partitions;
            int reminder = partitionData.Length % partitions;

            List<string> tmpData = new List<string>();

            for (int i = 0; i < partitions; i++)
            {
                string tmpString = null;

                for (int p = 0; p < partSize; p++)
                {
                    tmpString += partitionData[(i * partSize) + p];
                }

                if (i == partitions - 1 && reminder != 0)
                {
                    tmpString += partitionData.Substring(partitionData.Length - reminder);
                }

                tmpData.Add(tmpString);
            }

            input.InsertRange(index, tmpData);
        }
    }
}
