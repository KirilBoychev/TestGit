using System;
using System.Linq;

namespace T01.ActivationKeys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Generate")
            {
                string[] commandArr = command
                    .Split(">>>", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string commandName = commandArr[0];

                if (commandName == "Contains")
                {
                    string subString = commandArr[1];
                    if (input.Contains(subString))
                    {
                        Console.WriteLine($"{input} contains {subString}");
                    }
                    else
                    {
                        Console.WriteLine($"Substring not found!");
                    }
                }
                else if (commandName == "Flip")
                {
                    string upperLower = commandArr[1];
                    int startIndex = int.Parse(commandArr[2]);
                    int endIndex = int.Parse(commandArr[3]);

                    string sub = input.Substring(startIndex, endIndex - startIndex);
                    if (upperLower == "Upper")
                    {
                        input = input.Replace(sub, sub.ToUpper());
                    }
                    else if (upperLower == "Lower")
                    {
                        input = input.Replace(sub, sub.ToLower());
                    }
                    Console.WriteLine(input);
                }
                else if (commandName == "Slice")
                {
                    int startIndex = int.Parse(commandArr[1]);
                    int endIndex = int.Parse(commandArr[2]);
                    input = input.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(input);
                }
            }

            Console.WriteLine($"Your activation key is: {input}");
        }
    }
}
