using System;
using System.Collections.Generic;
using System.Linq;

namespace Т07.ListManipulationAdvanced
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
            bool flag = false;

            while (command != "end")
            {
                List<string> commandList = command.Split().ToList();

                int currentNum = 0;

                if (commandList.Count == 2)
                {
                    currentNum = int.Parse(commandList[1]);
                }
                else if (commandList.Count == 3)
                {
                    currentNum = int.Parse(commandList[2]);
                }

                if (commandList[0] == "Contains")
                {
                    if (readList.Contains(currentNum))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (commandList[0] == "PrintEven")
                {
                    List<int> evenNumbers = new List<int>();
                    for (int index = 0; index < readList.Count; index++)
                    {
                        if (readList[index] % 2 == 0)
                        {
                            evenNumbers.Add(readList[index]);
                        }
                    }
                    Console.WriteLine(string.Join(' ', evenNumbers));
                }
                else if (commandList[0] == "PrintOdd")
                {
                    List<int> oddNumbers = new List<int>();
                    for (int index = 0; index < readList.Count; index++)
                    {
                        if (readList[index] % 2 != 0)
                        {
                            oddNumbers.Add(readList[index]);
                        }
                    }
                    Console.WriteLine(string.Join(' ', oddNumbers));
                }
                else if (commandList[0] == "GetSum")
                {
                    int sum = 0;
                    for (int index = 0; index < readList.Count; index++)
                    {
                        sum += readList[index];
                    }
                    Console.WriteLine(sum);
                }
                else if (commandList[0] == "Filter")
                {
                    List<int> newList = new List<int>();
                    switch (commandList[1])
                    {
                        case "<":
                            for (int index = 0; index < readList.Count; index++)
                            {
                                if (readList[index] < currentNum)
                                {
                                    newList.Add(readList[index]);
                                }
                            }
                            break;
                        case ">":
                            for (int index = 0; index < readList.Count; index++)
                            {
                                if (readList[index] > currentNum)
                                {
                                    newList.Add(readList[index]);
                                }
                            }
                            break;
                        case "<=":
                            for (int index = 0; index < readList.Count; index++)
                            {
                                if (readList[index] <= currentNum)
                                {
                                    newList.Add(readList[index]);
                                }
                            }
                            break;
                        case ">=":
                            for (int index = 0; index < readList.Count; index++)
                            {
                                if (readList[index] >= currentNum)
                                {
                                    newList.Add(readList[index]);
                                }
                            }
                            break;
                    }

                    Console.WriteLine(string.Join(' ', newList));
                }
                else if (commandList[0] == "Add" || commandList[0] == "Remove" || commandList[0] == "RemoveAt" || commandList[0] == "Insert")
                {
                    //string list1 = string.Empty;
                    //for (int index = 0; index < readList.Count; index++)
                    //{
                    //    st
                    //}
                    List<int> newList = readList;

                    int num = 0;
                    if (commandList[0] == "Add")
                    {
                        num = int.Parse(commandList[1]);
                        newList.Add(num);
                    }
                    else if (commandList[0] == "Remove")
                    {
                        num = int.Parse(commandList[1]);
                        newList.Remove(num);
                    }
                    else if (commandList[0] == "RemoveAt")
                    {
                        num = int.Parse(commandList[1]);
                        newList.RemoveAt(num);
                    }
                    else if (commandList[0] == "Insert")
                    {
                        num = int.Parse(commandList[1]);
                        int num2 = int.Parse(commandList[2]);
                        newList.Insert(num2, num);
                    }

                    flag = true;
                }

                command = Console.ReadLine();
            }
            if (flag == true)
            {
                Console.WriteLine(String.Join(' ', readList));
            }
        }
    }

    //static List<int> PreviousTask(string command, List<int> list)
    //{
    //    List<string> listCommand = command
    //                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    //                .ToList();
    //    List<int> listNew = new List<int>();

    //    int num = 0;
    //    if (listCommand[0] == "Add")
    //    {
    //        num = int.Parse(listCommand[1]);
    //        list.Add(num);
    //    }
    //    else if (listCommand[0] == "Remove")
    //    {
    //        num = int.Parse(listCommand[1]);
    //        list.Remove(num);
    //    }
    //    else if (listCommand[0] == "RemoveAt")
    //    {
    //        num = int.Parse(listCommand[1]);
    //        list.RemoveAt(num);
    //    }
    //    else if (listCommand[0] == "Insert")
    //    {
    //        num = int.Parse(listCommand[1]);
    //        int num2 = int.Parse(listCommand[2]);
    //        list.Insert(num2, num);
    //    }

    //    listNew = list;

    //    return listNew;
    //}
}
