using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace T02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359(-| )2\1[0-9]{3}\1[0-9]{4}\b";

            string input = Console.ReadLine();

            MatchCollection everyOne = Regex.Matches(input, pattern);

            var matches = everyOne
                .Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToList();

            Console.WriteLine(string.Join(", ", matches));

        }
    }
}
