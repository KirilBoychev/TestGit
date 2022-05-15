using System;
using System.Linq;

namespace T01.PasswordReset
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Done")
            {
                string[] commandArr = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string substring = string.Empty;

                string commandName = commandArr[0];
                if (commandName == "TakeOdd")
                {
                    for (int i = 1; i < input.Length; i++)
                    {
                        if (i % 2 == 1)
                        {
                            substring += input[i];
                        }
                    }
                    input = substring;
                    Console.WriteLine(input);
                }
                else if (commandName == "Cut")
                {
                    int index = int.Parse(commandArr[1]);
                    int lenght = int.Parse(commandArr[2]);
                    input = input.Remove(index, lenght);
                    Console.WriteLine(input);
                }
                else if (commandName == "Substitute")
                {
                    substring = commandArr[1];
                    string substitute = commandArr[2];
                    if (input.Contains(substring))
                    {
                        input = input.Replace(substring, substitute);
                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine($"Nothing to replace!");
                    }
                }
            }

            Console.WriteLine($"Your password is: {input}");
        }
    }
}
