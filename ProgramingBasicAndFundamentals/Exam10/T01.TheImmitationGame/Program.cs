using System;
using System.Linq;

namespace T01.TheImmitationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Decode")
            {
                string[] commandArr = command
                    .Split('|', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string currOne = commandArr[0];

                if (currOne == "Move")
                {
                    int numberOfLetters = int.Parse(commandArr[1]);
                    string curr = input.Substring(0, numberOfLetters);
                    input = input.Remove(0, numberOfLetters);
                    input = input.Insert(input.Length, curr);
                }
                else if (currOne == "Insert")
                {
                    int index = int.Parse(commandArr[1]);
                    string value = commandArr[2];
                    input = input.Insert(index, value);
                }
                else if (currOne == "ChangeAll")
                {
                    string substring = commandArr[1];
                    string replacement = commandArr[2];
                    input = input.Replace(substring, replacement);
                }
            }

            Console.WriteLine($"The decrypted message is: {input}");
        }
    }
}
