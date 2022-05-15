using System;
using System.Collections.Generic;
using System.Linq;

namespace T06.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                List<string> listCommand = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                int num = 0;
                if (listCommand[0] == "Add")
                {
                    num = int.Parse(listCommand[1]);
                    list.Add(num);
                }
                else if (listCommand[0] == "Remove")
                {
                    num = int.Parse(listCommand[1]);
                    list.Remove(num);
                }
                else if (listCommand[0] == "RemoveAt")
                {
                    num = int.Parse(listCommand[1]);
                    list.RemoveAt(num);
                }
                else if (listCommand[0] == "Insert")
                {
                    num = int.Parse(listCommand[1]);
                    int num2 = int.Parse(listCommand[2]);
                    list.Insert(num2, num);
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', list));
        }
    }
}
