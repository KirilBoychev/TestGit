using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputList = Console.ReadLine();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Travel")
            {
                string[] commandArr = command
                    .Split(':', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string com = commandArr[0];

                if (com == "Add Stop")
                {
                    int index = int.Parse(commandArr[1]);
                    string value = commandArr[2];

                    if (index >= 0 && index < inputList.Length)
                    {
                        inputList = inputList.Insert(index, value);
                    }
                    Console.WriteLine(inputList);
                }
                else if (com == "Remove Stop")
                {
                    int startIndex = int.Parse(commandArr[1]);
                    int endIndex = int.Parse(commandArr[2]);

                    if (startIndex >= 0 && endIndex < inputList.Length)
                    {
                        inputList = inputList.Remove(startIndex, endIndex - startIndex + 1);
                    }
                    Console.WriteLine(inputList);
                }
                else if (com == "Switch")
                {
                    string oldOne = commandArr[1];
                    string newOne = commandArr[2];
                    if (inputList.Contains(oldOne))
                    {
                        inputList = inputList.Replace(oldOne, newOne);
                    }
                    Console.WriteLine(inputList);
                }
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {inputList}");
        }
    }
}
