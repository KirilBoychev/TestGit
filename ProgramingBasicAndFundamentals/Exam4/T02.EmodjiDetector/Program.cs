using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace T02.EmodjiDetector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string patternEmoji = @"(::|\*\*)(?<emoji>[A-Z][a-z]{2,})\1";
            MatchCollection matches = Regex.Matches(input, patternEmoji);

            string patternDigit = @"(?<name>[0-9])";
            MatchCollection digits = Regex.Matches(input, patternDigit);
            long sum = 1;
            foreach (Match match in digits)
            {
                long currNum = long.Parse(match.Groups["name"].Value);
                sum *= currNum;
            }

            List<string> list = new List<string>();
            int counter = 0;
            foreach (Match match in matches)
            {
                counter++;
                string currOne = match.Groups["emoji"].Value;
                long sum2 = 0;
                for (int i = 0; i < currOne.Length; i++)
                {
                    sum2 += (long)(currOne[i]);
                }
                if (sum2 >= sum)
                {
                    list.Add(match.Value);
                }
            }

            Console.WriteLine($"Cool threshold: {sum}");
            Console.WriteLine($"{counter} emojis found in the text. The cool ones are:");
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
