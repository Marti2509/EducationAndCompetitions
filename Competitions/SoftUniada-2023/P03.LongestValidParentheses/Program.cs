namespace P03.LongestValidParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<int> list = new List<int>();
            int count = 0;
            bool had = false;

            for (int i = 0; i < input.Length - 1; i += 2)
            {
                if (input[i] == '(' && input[i + 1] == ')' && had == true)
                {
                    count += 2;
                    had = true;
                }
                else if (input[i] == '(' && input[i + 1] == ')')
                {
                    count = 2;
                    had = true;
                }
                else
                {
                    list.Add(count);
                    had = false;
                    i--;
                }
            }

            list.Add(count);

            Console.WriteLine(list.Max());
        }
    }
}