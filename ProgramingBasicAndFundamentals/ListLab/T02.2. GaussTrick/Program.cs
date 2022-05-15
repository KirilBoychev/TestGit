using System;
using System.Collections.Generic;
using System.Linq;

namespace T02._2._GaussTrick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> newlist = new List<int>();

            if (list.Count % 2 == 0)
            {
                for (int index = 0; index < list.Count / 2; index++)
                {
                    newlist.Add(index);
                    newlist[index] = list[index] + list[(list.Count - 1) - index];
                }
            }

            if (list.Count % 2 != 0)
            {
                for (int index = 0; index < list.Count / 2; index++)
                {
                    newlist.Add(index);
                    newlist[index] = list[index] + list[(list.Count - 1) - index];
                }
                newlist.Add(list.Count / 2);
                newlist[list.Count / 2] = list[list.Count / 2];
            }

            Console.WriteLine(string.Join(' ', newlist));
        }
    }
}
