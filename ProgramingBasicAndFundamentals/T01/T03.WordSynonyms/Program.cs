using System;
using System.Collections.Generic;

namespace T03.WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

            string word = string.Empty;
            string synonym = string.Empty;

            for (int count = 0; count < n; count++)
            {
                word = Console.ReadLine();
                synonym = Console.ReadLine();

                if (words.ContainsKey(word) == false)
                {
                    words.Add(word, new List<string>());
                    words[word].Add(synonym);
                }
                else
                {
                    words[word].Add(synonym);
                }
            }

            foreach (var index in words)
            {
                Console.WriteLine($"{index.Key} - {string.Join(", ", index.Value)}");
            }
        }
    }
}
