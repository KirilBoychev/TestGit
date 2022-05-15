using System;
using System.Linq;

namespace T0101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command = string.Empty;
            while (((command = Console.ReadLine()) != "Finish"))
            {
                string[] commandArr = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string commandName = commandArr[0];

                if (commandName == "Replace")
                {
                    string oldChar = commandArr[1];
                    string newChar = commandArr[2];
                    input = input.Replace(oldChar, newChar);
                    Console.WriteLine(input);
                }
                else if (commandName == "Cut")
                {
                    int startIndex = int.Parse(commandArr[1]);
                    int endIndex = int.Parse(commandArr[2]);
                    if (startIndex > -1 && endIndex < input.Length)
                    {
                        input = input.Remove(startIndex, endIndex - startIndex + 1);
                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine($"Invalid indices!");
                    }
                }
                else if (commandName == "Make")
                {
                    string lowerUpper = commandArr[1];
                    if (lowerUpper == "Lower")
                    {
                        input = input.ToLower();
                        Console.WriteLine(input);
                    }
                    else if (lowerUpper == "Upper")
                    {
                        input = input.ToUpper();
                        Console.WriteLine(input);
                    }
                }
                else if (commandName == "Check")
                {
                    string subString = commandArr[1];
                    if (input.Contains(subString))
                    {
                        Console.WriteLine($"Message contains {subString}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {subString}");
                    }
                }
                else if (commandName == "Sum")
                {
                    int startIndex = int.Parse(commandArr[1]);
                    int endIndex = int.Parse(commandArr[2]);
                    if (startIndex > -1 && endIndex < input.Length)
                    {
                        string subString = input.Substring(startIndex, endIndex - startIndex + 1);
                        int sum = 0;
                        for (int i = 0; i < subString.Length; i++)
                        {
                            char currOne = subString[i];
                            sum += (int)currOne;
                        }
                        Console.WriteLine(sum);
                    }
                    else
                    {
                        Console.WriteLine($"Invalid indices!");
                    }
                }
            }
        }
    }
}
