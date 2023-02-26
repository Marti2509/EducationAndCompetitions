namespace P06.Pancakes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<long> nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            List<long> values = new List<long>();
            List<int> indexes = new List<int>();
            

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] < 0)
                {
                    continue;
                }

                long currCount = nums[i];

                for (int j = i + 1; j < nums.Count; j++)
                {
                    if (nums[j] < 0)
                    {
                        values.Add(currCount);
                        indexes.Add(i);
                        indexes.Add(j - 1);
                        break;
                    }
                    else
                    {
                        currCount += nums[j];
                    }

                    if (j == nums.Count - 1)
                    {
                        values.Add(currCount);
                        indexes.Add(i);
                        indexes.Add(nums.Count - 1);
                    }
                }
            }

            Dictionary<long, List<int>> biggest = new Dictionary<long, List<int>>();
            long biggestSum = 0;

            int countIndex = 0;

            foreach (long i in values)
            {
                if (i > biggestSum)
                {
                    biggest.Remove(biggestSum);
                    biggestSum = i;
                    biggest.Add(biggestSum, new List<int>() { indexes[countIndex++], indexes[countIndex++] });
                }
                else if (i == biggestSum)
                {
                    if ((indexes[countIndex += 1] - indexes[countIndex -= 1]) > (biggest[i][1] - biggest[i][0]))
                    {
                        biggest.Remove(biggestSum);
                        biggestSum = i;
                        biggest.Add(biggestSum, new List<int>() { indexes[countIndex++], indexes[countIndex++] });
                    }
                    else if (indexes[countIndex] < biggest[i][0])
                    {
                        biggest.Remove(biggestSum);
                        biggestSum = i;
                        biggest.Add(biggestSum, new List<int>() { indexes[countIndex++], indexes[countIndex++] });
                    }
                }
                else
                {
                    countIndex += 2;
                }
            }

            foreach (long i in biggest.Keys)
            {
                Console.Write(i + " ");
                Console.WriteLine(string.Join(" ", biggest[i]));
            }
        }
    }
}