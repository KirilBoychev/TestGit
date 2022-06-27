using System;
using System.Collections.Generic;
using System.Linq;

namespace T05.FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pieces = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int capacity = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            int sum = 0;

            for (int i = pieces.Length - 1; i >= 0; i--)
            {
                if (sum + pieces[i] < capacity)
                {
                    sum += pieces[i];
                }
                else if (sum + pieces[i] == capacity)
                {
                    sum += pieces[i];
                    stack.Push(sum);
                    sum = 0;
                }
                else if (sum + pieces[i] > capacity)
                {
                    stack.Push(sum);
                    sum = 0;
                    sum += pieces[i];
                }

                if (i == 0 && sum != 0)
                {
                    stack.Push(sum);
                }
            }

            Console.WriteLine(stack.Count);
        }
    }
}
