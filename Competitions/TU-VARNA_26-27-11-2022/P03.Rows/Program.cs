using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        int tests = int.Parse(Console.ReadLine());

        for (int test = 0; test < tests; test++)
        {
            long counter = 0;
            int[] info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int x = info[0];
            int N = info[1];
            int y = info[2];

            for (int a = 0; a < x; a++)
            {
                long sum = a;

                if (N != 1)
                {
                    for (int b = 0; b < x; b++)
                    {
                        if (N != 2)
                        {
                            for (int c = 0; c < x; c++)
                            {
                                if (N != 3)
                                {
                                    for (int d = 0; d < x; d++)
                                    {
                                        if (N != 4)
                                        {
                                            for (int e = 0; e < x; e++)
                                            {
                                                if (N != 5)
                                                {
                                                    for (int f = 0; f < x; f++)
                                                    {
                                                        if (N != 6)
                                                        {
                                                            for (int g = 0; g < x; g++)
                                                            {
                                                                if (N != 7)
                                                                {
                                                                    for (int h = 0; h < x; h++)
                                                                    {
                                                                        if (N != 8)
                                                                        {
                                                                            for (int i = 0; i < x; i++)
                                                                            {
                                                                                if (N != 9)
                                                                                {
                                                                                    for (int j = 0; j < x; j++)
                                                                                    {
                                                                                        if (N != 10)
                                                                                        {
                                                                                            for (int k = 0; k < x; k++)
                                                                                            {
                                                                                                if (N != 11)
                                                                                                {
                                                                                                    for (int l = 0; l < x; l++)
                                                                                                    {
                                                                                                        if (N != 12)
                                                                                                        {
                                                                                                            for (int m = 0; m < x; m++)
                                                                                                            {
                                                                                                                if (N != 13)
                                                                                                                {
                                                                                                                    for (int n = 0; n < x; n++)
                                                                                                                    {
                                                                                                                        for (int o = 0; o < x; o++)
                                                                                                                        {
                                                                                                                            if (N != 14)
                                                                                                                            {
                                                                                                                                for (int p = 0; p < x; p++)
                                                                                                                                {
                                                                                                                                    if (N != 15)
                                                                                                                                    {
                                                                                                                                        for (int q = 0; q < x; q++)
                                                                                                                                        {
                                                                                                                                            if (N != 16)
                                                                                                                                            {
                                                                                                                                                for (int r = 0; r < x; r++)
                                                                                                                                                {
                                                                                                                                                    if (N != 17)
                                                                                                                                                    {
                                                                                                                                                        for (int s = 0; s < x; s++)
                                                                                                                                                        {
                                                                                                                                                            if (a + b + c + d + e + f + g + i + j + k + l + n + o + p + q + r + s + m + h < y)
                                                                                                                                                                counter++;
                                                                                                                                                        }
                                                                                                                                                    }
                                                                                                                                                    else
                                                                                                                                                        if (a + b + c + d + e + f + g + i + j + k + l + n + o + p + q + r + m + h < y)
                                                                                                                                                        counter++;
                                                                                                                                                }
                                                                                                                                            }
                                                                                                                                            else
                                                                                                                                                if (a + b + c + d + e + f + g + i + j + k + l + n + o + p + q + m + h < y)
                                                                                                                                                counter++;
                                                                                                                                        }
                                                                                                                                    }
                                                                                                                                    else
                                                                                                                                        if (a + b + c + d + e + f + g + i + j + k + l + n + o + p + m + h < y)
                                                                                                                                        counter++;
                                                                                                                                }
                                                                                                                            }
                                                                                                                            else
                                                                                                                                if (a + b + c + d + e + f + g + i + j + k + l + n + o + m + h < y)
                                                                                                                                counter++;
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                                else
                                                                                                                    if (a + b + c + d + e + f + g + i + j + k + l + m + h < y)
                                                                                                                    counter++;
                                                                                                            }
                                                                                                        }
                                                                                                        else
                                                                                                            if (a + b + c + d + e + f + g + i + j + k + l + h < y)
                                                                                                            counter++;
                                                                                                    }
                                                                                                }
                                                                                                else
                                                                                                    if (a + b + c + d + e + f + g + i + j + k + h < y)
                                                                                                    counter++;
                                                                                            }
                                                                                        }
                                                                                        else
                                                                                            if (a + b + c + d + e + f + g + i + j + h < y)
                                                                                            counter++;
                                                                                    }
                                                                                }
                                                                                else
                                                                                    if (a + b + c + d + e + f + g + i + h < y)
                                                                                    counter++;
                                                                            }
                                                                        }
                                                                        else
                                                                            if (a + b + c + d + e + f + g + h < y)
                                                                            counter++;
                                                                    }
                                                                }
                                                                else
                                                                    if (a + b + c + d + e + f + g < y)
                                                                    counter++;
                                                            }
                                                        }
                                                        else
                                                            if (a + b + c + d + e + f < y)
                                                            counter++;
                                                    }
                                                }
                                                else
                                                    if (a + b + c + d + e < y)
                                                    counter++;
                                            }
                                        }
                                        else
                                            if (a + b + c + d < y)
                                            counter++;
                                    }
                                }
                                else
                                    if (a + b + c < y)
                                    counter++;
                            }
                        }
                        else
                            if (a + b < y)
                            counter++;
                    }
                }
                else
                    if (sum < y)
                    counter++;
            }

            Console.WriteLine(counter);
        }
    }
}
