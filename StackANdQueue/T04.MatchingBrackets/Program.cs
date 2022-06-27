using System;
using System.Collections.Generic;

namespace T04.MatchingBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                //char currIndex = input[i];
                if (input[i] == '(')
                {
                    stack.Push(i);
                }
                if (input[i] ==')')
                {
                    int startIndex = stack.Pop();
                    int endIdex = i;
                    string currOne = input.Substring(startIndex, endIdex - startIndex + 1);
                    Console.WriteLine(currOne);
                }
            }
        }
    }
}
