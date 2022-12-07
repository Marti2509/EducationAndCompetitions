using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

internal class Solution
{
    static void Main(string[] args)
    {
        while (true)
        {
            long[] info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();

            if (info[0] <= 1 || info[0] >= 101)
            {
                break;
            }

            long maxNum = info[1];

            long currMax = 0;

            long[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                long num1 = nums[i];

                for (int j = i + 1; j < nums.Length; j++)
                {
                    long num2 = nums[j];

                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        long num3 = nums[k];

                        long sum = num1 + num2 + num3;

                        if (currMax < sum && sum <= maxNum)
                        {
                            currMax = sum;
                        }
                    }
                }
            }

            Console.WriteLine(currMax);
        }
    }
}
