using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace T02.MirrorWords
{
    internal class Program
    {
        public static object Dictiona { get; private set; }

        static void Main(string[] args)
        {
            string pattern = @"(#|@)(?<firstWord>[A-Za-z]{3,})\1{2}(?<secondWord>[A-Za-z]{3,})\1";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);

            Dictionary<string, string> dict = new Dictionary<string, string>();

            int counter = 0;
            foreach (Match match in matches)
            {
                counter++;
                string reverseWord = match.Groups["secondWord"].Value;
                string currOne = string.Empty;
                for (int i = reverseWord.Length - 1; i > -1 ; i--)
                {
                    currOne += reverseWord[i];
                }
                reverseWord = currOne;

                if (match.Groups["firstWord"].Value == reverseWord)
                {
                    dict.Add(match.Groups["firstWord"].Value, match.Groups["secondWord"].Value);
                }
            }
            if (counter == 0)
            {
                Console.WriteLine($"No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{counter} word pairs found!");

            }

            if (dict.Count != 0)
            {
                Console.WriteLine($"The mirror words are:");
                List<string> final = new List<string>();
                foreach (var item in dict)
                {
                    string currO = item.Key + " <=> " + item.Value;
                    final.Add(currO);
                }
                Console.WriteLine(string.Join(", ", final));
            }
            else
            {
                Console.WriteLine($"No mirror words!");
            }
        }
    }
}
