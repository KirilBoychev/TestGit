using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.MaximumandMinimumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] currNumbs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (currNumbs.Length == 2)
                {
                    stack.Push(currNumbs[1]);
                }
                else if (currNumbs.Length == 1)
                {
                    if (currNumbs[0] == 2)
                    {
                        if (stack.Count > 0)
                        {
                            stack.Pop();
                        }
                    }
                    else if (currNumbs[0] == 3 && stack.Count > 0)
                    {
                        Console.WriteLine($"{stack.Max()}");
                    }
                    else if (currNumbs[0] == 4 && stack.Count > 0)
                    {
                        Console.WriteLine($"{stack.Min()}");
                    }
                }
            }

            Console.WriteLine($"{string.Join(", ", stack)}");
        }
    }
}
