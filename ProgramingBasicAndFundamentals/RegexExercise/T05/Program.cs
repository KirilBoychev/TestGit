using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace T05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            input.Sort();

            int counter1 = 0;
            int counter2 = 0;

            Dictionary<int, double> final = new Dictionary<int, double>();


            for (int i = 0; i < input.Count; i++)
            {
                string healthPattern = @"(?<health>[^0-9+\-*\/.])";
                string damagePattern = @"(?<damage>(\+|-)?\d+(\.\d+)?)";
                string multiplyPattern = @"[*]";
                string dividePattern = @"[\/]";

                MatchCollection matches = Regex.Matches(input[i], healthPattern);
                MatchCollection matches2 = Regex.Matches(input[i], damagePattern);
                MatchCollection matches3 = Regex.Matches(input[i], multiplyPattern);
                MatchCollection matches4 = Regex.Matches(input[i], dividePattern);

                int healthSum = 0;
                double damageSum = 0;
                foreach (Match item in matches)
                {
                    string currSt = item.Groups["health"].Value;
                    char currCh = currSt[0];
                    Console.WriteLine(currCh);
                    healthSum += currCh - '0';
                }
                foreach (Match item in matches2)
                {
                    damageSum += double.Parse(item.Groups["damage"].Value);
                }
                foreach (Match item in matches3)
                {
                    counter1++;
                }
                foreach (Match item in matches4)
                {
                    counter2++;
                }
                if (counter1 > counter2)
                {
                    counter1 -= counter2;
                    damageSum *= counter1 * 2;
                }
                else if (counter1 < counter2)
                {
                    counter2 -= counter1;
                    damageSum /= counter1 * 2;
                }

                final.Add(healthSum, damageSum);
                Console.Write($"{input[i]} - ");
                Console.Write($"{healthSum} health, {damageSum} damage");
                Console.WriteLine();
            }


        }
    }
}
