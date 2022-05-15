using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sequanceOfElements = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string inputConsole = Console.ReadLine();
            int counter = 0;

            while (inputConsole != "end")
            {
                List<int> input = inputConsole
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                counter++;

                if (input[0] == input[1] || input[0] < 0 || input[0] >= sequanceOfElements.Count || input[1] < 0 || input[1] >= sequanceOfElements.Count)
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    sequanceOfElements.Insert(sequanceOfElements.Count / 2, $"-{counter}a");
                    sequanceOfElements.Insert(sequanceOfElements.Count / 2, $"-{counter}a");
                    inputConsole = Console.ReadLine();
                    continue;
                }

                if (sequanceOfElements[input[0]] != sequanceOfElements[input[1]])
                {
                    Console.WriteLine("Try again!");
                }
                else
                {
                    string currentInputIndex = sequanceOfElements[input[0]];
                    sequanceOfElements.RemoveAt(input[0]);
                    sequanceOfElements.RemoveAt(input[1] - 1);
                    Console.WriteLine($"Congrats! You have found matching elements - {currentInputIndex}!");
                }

                if (sequanceOfElements.Count == 0)
                {
                    Console.WriteLine($"You have won in {counter} turns!");
                    break;
                }

                inputConsole = Console.ReadLine();
            }

            if (inputConsole == "end")
            {
                if (sequanceOfElements.Count > 0)
                {
                    Console.WriteLine("Sorry you lose :(");
                    Console.WriteLine(String.Join(' ', sequanceOfElements));
                }
            }
        }
    }
}
