using System;
using System.Text.RegularExpressions;

namespace T02.FancyBarcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string concat = "";

                string pattern = @"@#+(?<name>[A-Z][A-Za-z\d+]{4,}[A-Z])@#+";

                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    foreach (var index in input)
                    {
                        if (char.IsDigit(index))
                        {
                            concat += index;
                        }
                    }

                    if (concat == "")
                    {
                        concat = "00";
                    }

                    Console.WriteLine($"Product group: {concat}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
