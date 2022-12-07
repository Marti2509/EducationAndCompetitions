using System;
using System.Collections.Generic;
using System.IO;

namespace Solution
{

    public class NotesStore
    {
        private Dictionary<string, List<string>> notes;

        public NotesStore()
        {
            notes = new Dictionary<string, List<string>>();
        }

        public void AddNote(string state, string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Name cannot be empty");
            }

            if (state != "completed" && state != "active" && state != "others")
            {
                throw new Exception($"Invalid state {state}");
            }

            if (!notes.ContainsKey(state))
            {
                notes[state] = new List<string>();
            }

            notes[state].Add(name);
        }

        public List<string> GetNotes(string state)
        {
            if (state != "completed" && state != "active" && state != "others")
            {
                throw new Exception($"Invalid state {state}");
            }

            if (notes.ContainsKey(state) && notes[state].Count != 0)
            {
                return notes[state];
            }

            return new List<string>();
        }
    }

    public class Solution
    {
        public static void Main()
        {
            var notesStoreObj = new NotesStore();
            var n = int.Parse(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
                var operationInfo = Console.ReadLine().Split(' ');
                try
                {
                    if (operationInfo[0] == "AddNote")
                        notesStoreObj.AddNote(operationInfo[1], operationInfo.Length == 2 ? "" : operationInfo[2]);
                    else if (operationInfo[0] == "GetNotes")
                    {
                        var result = notesStoreObj.GetNotes(operationInfo[1]);
                        if (result.Count == 0)
                            Console.WriteLine("No Notes");
                        else
                            Console.WriteLine(string.Join(",", result));
                    }
                    else
                    {
                        Console.WriteLine("Invalid Parameter");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
        }
    }
}