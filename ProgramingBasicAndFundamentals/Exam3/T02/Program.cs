using System;
using System.Text.RegularExpressions;

namespace T02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(@#+)([A-Z]{1}[A-Za-z\d]{4,}[A-Z]{1})(@#+)";

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match match = Regex.Match(input, pattern);

                string sumDigits = "";
                if (match.Success)
                {
                    for (int j = 0; j < input.Length; j++)
                    {
                        if (char.IsDigit(input[j]))
                        {
                            sumDigits += input[j];
                        }
                    }
                    if (sumDigits == string.Empty)
                    {
                        sumDigits = "00";
                    }
                    Console.WriteLine($"Product group: {sumDigits}");
                }
                else
                {
                    Console.WriteLine($"Invalid barcode");
                }
            }
        }
    }
}
