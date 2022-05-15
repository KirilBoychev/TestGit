using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace T1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[>]{2}(?<name>[A-Za-z]+)[<]{2}(?<price>\d+(\.\d+)?)\!(?<quantity>\d+)";

            decimal total = 0m;

            List<string> list = new List<string>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    list.Add(name);
                    total += price * (decimal)quantity;
                }
            }

            PrintOutput(list, total);
        }

        static void PrintOutput(List<string> names, decimal total)
        {
            Console.WriteLine($"Bought furniture:");

            foreach (var name in names)
            {
                Console.WriteLine($"{name}");
            }

            Console.WriteLine($"Total money spend: {total:f2}");
        }
    }
}
