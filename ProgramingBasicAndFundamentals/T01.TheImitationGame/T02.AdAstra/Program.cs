using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace T02.AdAstra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] delimeter1 = {'#', '|'};
            List<string> input = Console.ReadLine()
                .Split(delimeter1)
                .ToList();
            
            Console.WriteLine(string.Join(' ', input));
            List<string[]> output = new List<string[]>();

            int sum = 0;    

            for (int i = 0; i < input.Count; i++)
            {
                bool flag = false;
                for (int j = 0; j < input[i].Length; j++)
                {
                    if (char.IsLetter(input[i][j]) || input[i][j] == ' ')
                    {
                        flag = true;
                    }
                }
                if (flag == true)
                {
                    bool flag1 = false;
                    if (input[i + 1].Length == 8 && input[i + 1][2] == '/' && input[i + 1][5] == '/')
                    {
                        flag1 = true;
                    }
                    if (flag1 == true)
                    {
                        bool flag2 = false;
                        for (int j = 0; j < input[i + 2].Length; j++)
                        {
                            if (char.IsDigit(input[i + 2][j]))
                            {
                                flag2 = true;
                            }
                        }
                        if (flag2 == true)
                        {
                            string[] currOne = new string[] { input[i], input[i + 1], input[i + 2] };
                            output.Add(currOne);
                            sum += int.Parse(currOne[2]);
                            //Console.WriteLine(sum);
                        }
                    }
                }
            }

            sum /= 2000;

            Console.WriteLine($"You have food to last you for: {sum} days!");
            foreach (var item in output)
            {
                Console.WriteLine($"Item: {item[0]}, Best before: {item[1]}, Nutrition: {item[2]}");
            }

            //foreach (var item in output)
            //{
            //    Console.WriteLine(string.Join("       ", item));
            //}


            //string input = Console.ReadLine();

            //string pattern = @"([#\|])(?<name>[A-Za-z\s]+)\1(?<date>\d{2}\/\d{2}\/\d{2})*\1(?<calories>\d{1,5})\1";

            //MatchCollection matches = Regex.Matches(input, pattern);

            //int caloriesTotal = 0;

            //foreach (Match match in matches)
            //{
            //    int calories = (int.Parse)(match.Groups["calories"].Value);

            //    caloriesTotal += calories;
            //}

            //int days = caloriesTotal / 2000;

            //Console.WriteLine($"You have food to last you for: {days} days!");

            //foreach (Match match in matches)
            //{
            //    Console.WriteLine($"Item: {match.Groups["name"].Value}, Best before: {match.Groups["date"].Value}, Nutrition: {match.Groups["calories"].Value}");

            //}
        }
    }
}
