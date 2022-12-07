using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        List<char> ch = new List<char>();

        string word = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());

        string newWord = word.Substring(n);

        for (int i = 0; i < word.Length - n; i++)
        {
            newWord += word[i];
        }

        for (int i = 0; i < newWord.Length; i++)
        {
            ch.Add(Convert.ToChar((int)newWord[i] + n));
        }

        foreach (var item in ch)
        {
            Console.Write(item);
        }
    }
}