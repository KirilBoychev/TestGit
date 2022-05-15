using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace T02.ShoppingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(#|\|)([A-Za-z\s]+)\1(\d{2}\/\d{2}\/\d{2})\1(\d{1,5})\1";

            MatchCollection matches = Regex.Matches(input, pattern);

            int callories = 0;
            foreach (Match match in matches)
            {
                int singleCallorie = int.Parse(match.Groups[4].Value);
                callories += singleCallorie;
            }
            callories /= 2000;

            Console.WriteLine($"You have food to last you for: {callories} days!");

            foreach (Match match1 in matches)
            {
                Console.WriteLine($"Item: {match1.Groups[2].Value}, Best before: {match1.Groups[3].Value}, Nutrition: {match1.Groups[4].Value}");
            }


            //List<string> inputList = input
            //    .Split('!', StringSplitOptions.RemoveEmptyEntries)
            //    .ToList();

            //string command = string.Empty;

            //while ((command = Console.ReadLine()) != "Go Shopping!")
            //{
            //    string[] commandArr = command
            //        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            //        .ToArray();

            //    if (!inputList.Contains(commandArr[1]))
            //    {
            //        continue;
            //    }

            //    if (commandArr[0] == "Urgent")
            //    {
            //        if (!inputList.Contains(commandArr[1]))
            //        {
            //            inputList.Insert(0, commandArr[1]);
            //        }
            //    }
            //    else if (commandArr[0] == "Unnecessary")
            //    {
            //        if (inputList.Contains(commandArr[1]))
            //        {
            //            inputList.Remove(commandArr[0]);
            //        }
            //    }
            //    else if (commandArr[0] == "Correct")
            //    {
            //        if (inputList.Contains(commandArr[1]))
            //        {
            //            int index = inputList.IndexOf(commandArr[1]);
            //            inputList.Insert(index, commandArr[2]);
            //            inputList.Remove(commandArr[1]);
            //        }
            //    }
            //    else if (commandArr[0] == "Rearrange")
            //    {
            //        if (inputList.Contains(commandArr[1]))
            //        {
            //            inputList.Remove(commandArr[1]);
            //            inputList.Add(commandArr[1]);
            //        }
            //    }
            //}

            //Console.WriteLine(String.Join(", ", inputList));
        }
    }
}
