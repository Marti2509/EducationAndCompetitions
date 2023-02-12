int[] rawNums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

Dictionary<int, int> keyValue = new Dictionary<int, int>();
List<int> list = new List<int>();

foreach (int currNum in rawNums)
{
    if (keyValue.ContainsKey(currNum))
    {
        keyValue[currNum]++;
    }
    else
    {
        keyValue.Add(currNum, 1);
    }
}

for (int i = 0; i < rawNums.Length; i++)
{
    int currBigestNum = int.MinValue;
    int currBigestValue = int.MinValue;

    foreach (var item in keyValue)
    {
        if (item.Value > currBigestValue)
        {
            currBigestValue = item.Value;
            currBigestNum = item.Key;
        }
        else if (item.Value == currBigestValue)
        {
            if (item.Key < currBigestNum)
            {
                currBigestValue = item.Value;
                currBigestNum = item.Key;
            }
        }
    }

    for (int k = 0; k < currBigestValue; k++)
    {
        list.Add(currBigestNum);
    }

    keyValue.Remove(currBigestNum);
}

Console.WriteLine(string.Join(" ", list));