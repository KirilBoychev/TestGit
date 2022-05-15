using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int counter = 0;
            string command = Console.ReadLine();

            while (command != "end")
            {
                int[] indexex = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int index1 = indexex[0];
                int index2 = indexex[1];

                counter++;

                if (index1 == index2)
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    inputList.Insert(inputList.Count / 2, $"-{counter}a");
                    inputList.Insert(inputList.Count / 2 + 1, $"-{counter}a");
                }
                else if (index1 < 0 || index1 >= inputList.Count)
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    inputList.Insert(inputList.Count / 2, $"-{counter}a");
                    inputList.Insert(inputList.Count / 2 + 1, $"-{counter}a");
                }
                else if (index2 < 0 || index2 >= inputList.Count)
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    inputList.Insert(inputList.Count / 2, $"-{counter}a");
                    inputList.Insert(inputList.Count / 2 + 1, $"-{counter}a");
                }
                else
                {
                    if (inputList[index1] == inputList[index2])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {inputList[index1]}!");
                        inputList.RemoveAt(index1);
                        inputList.RemoveAt(index2 - 1);
                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                    }
                }

                if (inputList.Count == 0)
                {
                    Console.WriteLine($"You have won in {counter} turns!");
                    break;
                }

                command = Console.ReadLine();
            }

            if (inputList.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(String.Join(' ', inputList));
            }
        }
    }
}
