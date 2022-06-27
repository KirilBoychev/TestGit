using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.BasicQueueOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int n = input[0];
            int s = input[1];
            int x = input[2];

            int[] numberOfElement = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>();
            
            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(numberOfElement[i]);
            }

            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (queue.Contains(x))
            {
                Console.WriteLine($"true");
            }
            else
            {
                Console.WriteLine($"{queue.Min()}");
            }
        }
    }
}
