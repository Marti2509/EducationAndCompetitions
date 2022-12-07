using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

class Solution
{
    static void Main(String[] args)
    {
        int numDays = 0;
        bool flag = false;

        int[] bdayInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int[] nowInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        int bdayDay = bdayInfo[0];
        int bdayMonth = bdayInfo[1];
        int nowDay = nowInfo[0];
        int nowMonth = nowInfo[1];
        int nowYear = nowInfo[2];

        if (bdayMonth == 02 && bdayDay == 29)
        {
            bdayDay--;
            numDays++;
            flag = true;
        }

        DateTime today = new DateTime(nowYear, nowMonth, nowDay);
        DateTime next = new DateTime(nowYear, bdayMonth, bdayDay);

        if (next < today)
            next = next.AddYears(1);

        if (flag)
        {
            for (int i = nowYear; ; i++)
            {
                if (!DateTime.IsLeapYear(i))
                {
                    numDays += 365;
                }
                else
                {
                    break;
                }
            }
        }

        numDays += (next - today).Days;
        Console.WriteLine(numDays);
    }
}