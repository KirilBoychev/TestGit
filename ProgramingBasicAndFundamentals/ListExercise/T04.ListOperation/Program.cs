using System;
using System.Collections.Generic;
using System.Linq;

namespace T04.ListOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                List<string> commandList = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                switch (commandList[0])
                {
                    case "Add":
                        inputList.Add(int.Parse(commandList[1]));
                        break;
                    case "Insert":
                        if (int.Parse(commandList[2]) < 0 || int.Parse(commandList[2]) >= inputList.Count)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            inputList.Insert(int.Parse(commandList[2]), int.Parse(commandList[1]));
                        }
                        break;
                    case "Remove":
                        if (int.Parse(commandList[1]) < 0 || int.Parse(commandList[1]) >= inputList.Count)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            inputList.RemoveAt(int.Parse(commandList[1]));
                        }
                        break;
                    case "Shift":
                        if (commandList[1] == "right")
                        {
                            for (int i = 0; i < int.Parse(commandList[2]); i++)
                            {
                                inputList.Insert(0, inputList[inputList.Count - 1]);
                                inputList.RemoveAt(inputList.Count - 1);
                            }
                        }
                        else if (commandList[1] == "left")
                        {
                            for (int i = 0; i < int.Parse(commandList[2]); i++)
                            {
                                inputList.Add(inputList[0]);
                                inputList.RemoveAt(0);
                            }
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", inputList));
        }
    }
}
