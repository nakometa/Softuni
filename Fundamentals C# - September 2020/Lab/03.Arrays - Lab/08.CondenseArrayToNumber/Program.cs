using System;
using System.Linq;

namespace _08.CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            while (nums.Length > 1)
            {
                int[] condenced = new int[nums.Length - 1];
                for (int j = 0; j < condenced.Length; j++)
                {
                    condenced[j] = nums[j] + nums[j + 1];
                }
                Array.Resize<int>(ref nums, condenced.Length);
                for (int k = 0; k < nums.Length; k++)
                {
                    nums[k] = condenced[k];
                }
            }
            Console.WriteLine(nums[0]);
        }
    }
}
