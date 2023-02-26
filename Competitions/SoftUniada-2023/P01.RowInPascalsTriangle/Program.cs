namespace P01.RowInPascalsTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()) + 1;
            long[][] jagged = new long[n][];

            for (int row = 0; row < jagged.Length; row++)
            {
                jagged[row] = new long[row + 1];
            }

            for (int row = 0; row < jagged.Length; row++)
            {
                jagged[row][0] = 1;

                for (int col = 1; col < jagged[row].Length - 1; col++)
                {
                    jagged[row][col] = jagged[row - 1][col] + jagged[row - 1][col - 1];
                }

                jagged[row][jagged[row].Length - 1] = 1;
            }

            Console.WriteLine(string.Join(' ', jagged[n - 1]));
        }
    }
}