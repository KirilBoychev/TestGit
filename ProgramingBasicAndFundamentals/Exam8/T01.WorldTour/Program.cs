using System;
using System.Linq;

namespace T01.WorldTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Travel")
            {
                string[] commandArr = command
                    .Split(':', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string comName = commandArr[0];

                if (comName == "Add Stop")
                {
                    int index = int.Parse(commandArr[1]);
                    string subString = commandArr[2];
                    if (index > -1 && index < input.Length)
                    {
                        input = input.Insert(index, subString);
                    }
                    Console.WriteLine(input);
                }
                else if (comName == "Remove Stop")
                {
                    int startIndex = int.Parse(commandArr[1]);
                    int endIndex = int.Parse(commandArr[2]);
                    if (startIndex > -1 && endIndex < input.Length)
                    {
                        input = input.Remove(startIndex, endIndex - startIndex + 1);
                    }
                    Console.WriteLine(input);
                }
                else if (comName == "Switch")
                {
                    string oldOne = commandArr[1];
                    string newOne = commandArr[2];
                    if (input.Contains(oldOne))
                    {
                        input = input.Replace(oldOne, newOne);
                    }
                    Console.WriteLine(input);
                }
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {input}");
        }
    }
}
