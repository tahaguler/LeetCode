using System;
using System.Collections.Generic;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {2, 7, 11, 15};
            int target = 9;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (dict.ContainsKey(complement))
                {
                    Console.WriteLine('[' + dict.GetValueOrDefault(complement).ToString() + ", " + i + ']');
                    return;
                }

                dict.Add(nums[i], i);
            }

            throw new Exception("No two sum solution");
        }
    }
}