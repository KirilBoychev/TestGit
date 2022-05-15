using System;
using System.Linq;

namespace T01SecretChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Reveal")
            {
                string[] commandArr = command
                    .Split(":|:", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string com = commandArr[0];

                if (com == "InsertSpace")
                {
                    int givenIndex = int.Parse(commandArr[1]);
                    input = input.Insert(givenIndex, " ");
                    Console.WriteLine(input);
                }
                else if (com == "Reverse")
                {
                    string subString = commandArr[1];
                    if (input.Contains(subString))
                    {
                        input = input.Remove(input.IndexOf(subString), subString.Length);
                        string newOne = string.Empty;
                        for (int i = subString.Length - 1; i >= 0 ; i--)
                        {
                            newOne += subString[i];
                        }
                        input = input.Insert(input.Length, newOne);
                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (com == "ChangeAll")
                {
                    string subString = commandArr[1];
                    string replacement = commandArr[2];
                    input = input.Replace(subString, replacement);
                    Console.WriteLine(input);
                }
            }
            Console.WriteLine($"You have a new text message: {input}");
        }
    }
}
