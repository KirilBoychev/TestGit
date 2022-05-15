using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] intputWords = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string word in intputWords)
            {
                string wordInALowerCase = word.ToLower();
                if (counts.ContainsKey(wordInALowerCase))
                {
                    counts[wordInALowerCase]++;
                }
                else
                {
                    counts.Add(wordInALowerCase, 1);
                }
            }

            foreach (var index in counts)
            {
                if (index.Value % 2 != 0)
                {
                    Console.Write($"{index.Key} ");
                }
            }
        }
    }
}
