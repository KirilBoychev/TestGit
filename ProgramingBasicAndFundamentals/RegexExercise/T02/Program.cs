using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace T02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();

            int distance = 0;

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end of race")
            {
                string currOne = string.Empty;

                string namePattern = @"(?<name>[A-Za-z]+)";
                MatchCollection matches = Regex.Matches(command, namePattern);
                foreach (Match match in matches)
                {
                    currOne += match.Groups["name"].Value;
                }

                if (input.Contains(currOne))
                {
                    string distance1 = @"(?<dis>[0-9])";
                    MatchCollection match2 = Regex.Matches(command, distance1);
                    foreach (Match match in match2)
                    {
                        distance += int.Parse(match.Groups["dis"].Value);
                    }

                    if (keyValuePairs.ContainsKey(currOne))
                    {
                        keyValuePairs[currOne] += distance;
                    }
                    else
                    {
                        keyValuePairs.Add(currOne, distance);
                    }
                }

                distance = 0;
            }

            var ordered = keyValuePairs.OrderByDescending(s => s.Value).ToDictionary(s => s.Key, s => s.Value);

            int counter = 0;
            foreach (var item in ordered)
            {
                counter++;
                if (counter == 1)
                {
                    Console.WriteLine($"1st place: {item.Key}");
                }
                else if (counter == 2)
                {
                    Console.WriteLine($"2nd place: {item.Key}");
                }
                else if (counter == 3)
                {
                    Console.WriteLine($"3rd place: {item.Key}");
                }
            }
        }
    }
}
