using System;
using System.Collections.Generic;
using System.Linq;

namespace T01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int capacityOfSingleVagon = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "end")
            {
                List<string> commandList = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                int currentNum = 0;

                if (commandList.Count == 2)
                {
                    commandList[0] = "Add";
                    currentNum = int.Parse(commandList[1]);
                    train.Add(currentNum);
                }
                else if (commandList.Count == 1)
                {
                    currentNum = int.Parse(commandList[0]);
                    
                    for (int index = 0; index < train.Count; index++)
                    {
                        int currentAvailable = capacityOfSingleVagon - train[index];
                        if (currentAvailable >= currentNum)
                        {
                            train[index] += currentNum;
                            break;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', train));
        }
    }
}
