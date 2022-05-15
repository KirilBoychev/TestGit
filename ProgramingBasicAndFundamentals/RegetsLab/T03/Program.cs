using System;
using System.Text.RegularExpressions;

namespace T03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(\d{2})(\/|.|-)([A-Z][a-z]{2})\2(\d{4})\b";

            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine($"Day: {match.Groups[1].Value}, Month: {match.Groups[3].Value}, Year: {match.Groups[4]}");
            }
        }
    }
}
