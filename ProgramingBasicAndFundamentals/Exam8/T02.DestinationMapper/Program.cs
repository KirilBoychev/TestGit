using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace T02.DestinationMapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(=|\/)(?<name>[A-Z][A-Za-z]{2,})(\1)";

            MatchCollection matches = Regex.Matches(input, pattern);

            List<string> list = new List<string>();

            int counter = 0;
            foreach (Match match in matches)
            {
                list.Add($"{match.Groups["name"].Value}");
                counter += match.Groups["name"].Value.Length;
            }

            if (list != null)
            {
                Console.WriteLine($"Destinations: {string.Join(", ", list)}");
                Console.WriteLine($"Travel Points: {counter}");
            }
            else
            {
                Console.WriteLine($"Destinations: ");
                Console.WriteLine($"Travel Points: {counter}");

            }
        }
    }
}
