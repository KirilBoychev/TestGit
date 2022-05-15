using System;
using System.Text.RegularExpressions;

namespace T02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(@|#){1,}(?<color>[a-z]{3,})(@|#){1,}(?<between>[^A-Za-z0-9]*)(\/{1,})(?<digit>\d+)(\/{1,})";

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine($"You found {match.Groups["digit"].Value} {match.Groups["color"].Value} eggs!");
            }
        }
    }
}
