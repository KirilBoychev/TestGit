using System;
using System.Collections.Generic;

namespace T01.Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<string> newOne = new Stack<string>();

            for (int i = 0; i < input.Length; i++)
            {
                newOne.Push($"{input[i]}");
            }

            Console.WriteLine($"{string.Join("", newOne)}");
        }
    }
}
