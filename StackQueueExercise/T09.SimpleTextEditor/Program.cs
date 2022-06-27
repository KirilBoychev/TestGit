using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T09.SimpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();

                if (command.StartsWith("1"))
                {
                    stack.Push(sb.ToString());

                    string textForAdd = command.Split(' ')[1];
                    sb.Append(textForAdd);
                }
                else if (command.StartsWith("2"))
                {
                    stack.Push(sb.ToString());

                    int count = int.Parse(command.Split(' ')[1]);
                    sb.Remove(sb.Length - count, count);
                }
                else if (command.StartsWith("3"))
                {
                    int index = int.Parse(command.Split(' ')[1]);
                    Console.WriteLine($"{sb[index - 1]}");
                }
                else if (command.StartsWith("4"))
                {
                    sb = new StringBuilder(stack.Pop());
                }
            }
        }
    }
}
