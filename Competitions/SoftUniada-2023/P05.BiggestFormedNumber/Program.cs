namespace P05.BiggestFormedNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            LargestNumberMethod(nums);
        }

        public static void LargestNumberMethod(List<int> inputList)
        {
            string output = string.Empty;

            List<string> newList = inputList.ConvertAll<string>(
                delegate (int i) { return i.ToString(); });

            newList.Sort(MyCompare);

            for (int i = 0; i < inputList.Count; i++)
            {
                output = output + newList[i];
            }

            if (output[0] == '0' && output.Length > 1)
            {
                Console.Write("0");
            }
            Console.Write(output);
        }

        internal static int MyCompare(string X, string Y)
        {
            // first append Y at the end of X
            string XY = X + Y;

            // then append X at the end of Y
            string YX = Y + X;

            // Now see which of the two
            // formed numbers is greater
            return XY.CompareTo(YX) > 0 ? -1 : 1;
        }
    }
}
