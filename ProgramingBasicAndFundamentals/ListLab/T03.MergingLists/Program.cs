using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> list2 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Console.WriteLine(string.Join(' ', resultList(list1, list2)));
        }

        static List<int> resultList(List<int> list1, List<int> list2)
        {
            List<int> finalList = new List<int>();
            finalList.AddRange(list1);
            finalList.AddRange(list2);

            for (int index = 0; index < finalList.Count - Math.Abs(list1.Count - list2.Count); index += 2)
            {
                finalList[index] = list1[index/2];
                finalList[index + 1] = list2[index / 2];
            }
            int counter = 0;
            if (list1.Count > list2.Count)
            {
                for (int index2 = finalList.Count - Math.Abs(list1.Count - list2.Count); index2 < finalList.Count; index2++)
                {
                    
                    finalList[index2] = list1[list2.Count + counter];
                    counter++;
                }
            }
            else
            {
                for (int index2 = finalList.Count - Math.Abs(list1.Count - list2.Count); index2 < finalList.Count; index2++)
                {
                    finalList[index2] = list2[list1.Count + counter];
                    counter++;
                }
            }
            return finalList;
        }
    }
}
