﻿namespace ListOfEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i]%2 == 0)
                {
                    Console.Write($"{nums[i]} ");
                }
            }
        }
    }
}
