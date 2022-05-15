using System;
using System.Linq;

namespace T01.TheImitationGame
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

                if (commandArr[0] == "Move")
                {
                    string substring = input.Substring(0, int.Parse(commandArr[1]));
                    input = input.Remove(0, int.Parse(commandArr[1]));
                    input = input + substring;
                }

                if (commandArr[0] == "Insert")
                {
                    int index = int.Parse(commandArr[1]);
                    string value = commandArr[2];

                    input = input.Insert(index, value);
                }

                if (commandArr[0] == "ChangeAll")
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] == char.Parse(commandArr[1]))
                        {
                            input = input.Remove(i, 1);
                            input = input.Insert(i, commandArr[2]);
                        }
                    }
                }
            }

            Console.WriteLine($"The decrypted message is: {input}");
        }
    }
}
