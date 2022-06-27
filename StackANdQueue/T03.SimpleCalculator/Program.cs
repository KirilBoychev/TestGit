using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace T03.SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Stack<int> stack = new Stack<int>();

            //Console.WriteLine(String.Join(' ', input));
            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0)
                {
                    stack.Push(int.Parse(input[i]));
                }
                else if (input[i] == "+")
                {
                    stack.Push(int.Parse(input[i + 1]) + stack.Peek());
                }
                else if (input[i] == "-")
                {
                    stack.Push(stack.Peek() - int.Parse(input[i + 1]));
                }
            }
            int sum = stack.Peek();
            Console.WriteLine(stack.Peek());
        }
    }
}
