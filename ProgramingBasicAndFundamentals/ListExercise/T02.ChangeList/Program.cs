using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> readList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                List<string> commandList = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                int currentElement = int.Parse(commandList[1]);

                if (commandList.Count == 2)
                {
                    commandList[0] = "Delete";
                    for (int index = 0; index < readList.Count; index++)
                    {
                        if (readList[index] == currentElement)
                        {
                            readList.RemoveAt(index);
                        }
                    }
                }
                else if (commandList.Count == 3)
                {
                    int position = int.Parse(commandList[2]);
                    readList.Insert(position, currentElement);
                }
            }

            Console.WriteLine(String.Join());
        }
    }
}
