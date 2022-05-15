using System;
using System.Linq;

namespace T01PasswordReset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string output = string.Empty;
            int counter = -1;

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Done")
            {
                string[] commandArr = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string firstWord = commandArr[0];

                if (firstWord == "TakeOdd")
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (i % 2 == 1)
                        {
                            output += input.Substring(i, 1);
                        }
                    }
                    input = output;
                    output = string.Empty;
                    Console.WriteLine(input);
                }

                if (firstWord == "Cut")
                {
                    int index = int.Parse(commandArr[1]);
                    int lenght = int.Parse(commandArr[2]);
                    
                    input = input.Remove(index, lenght);
                    Console.WriteLine(input);
                }

                if (firstWord == "Substitute")
                {
                    if (input.Contains(commandArr[1]))
                    {
                        input = input.Replace(commandArr[1], commandArr[2]);
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
