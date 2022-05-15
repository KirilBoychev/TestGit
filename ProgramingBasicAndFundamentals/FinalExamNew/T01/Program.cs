using System;
using System.Linq;

namespace T01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Finish")
            {
                string[] commandArr = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = commandArr[0];

                if (name == "Replace")
                {
                    string currChar = commandArr[1];
                    string newChar = commandArr[2];
                    if (true)
                    {

                    }
                }
            }
        }
    }
}
