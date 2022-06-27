using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>();

            foreach (var item in input)
            {
                stack.Push(item);
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()).ToLower() != "end")
            {
                string[] commandArr = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string currCommand = commandArr[0];

                if (currCommand.ToLower() == "add")
                {
                    int firstNum = int.Parse(commandArr[1]);
                    int secondNum = int.Parse(commandArr[2]);
                    stack.Push(firstNum);
                    stack.Push(secondNum);
                }
                else if (currCommand.ToLower() == "remove")
                {
                    int firstNum = int.Parse(commandArr[1]);
                    if (stack.Count >= firstNum)
                    {
                        for (int i = 0; i < firstNum; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
            }

            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
