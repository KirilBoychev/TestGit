using System;
using System.Collections.Generic;
using System.Linq;

namespace T07.AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputArray = Console.ReadLine()
                .Split('|')
                .ToList();
            inputArray.Reverse();

            List<int> final = new List<int>();

            for (int index = 0; index < inputArray.Count; index++)
            {
                string text = inputArray[index];
                
                //List<string> currentIndex = text.Split(' ', StringSplitOptions.TrimEntries)
                //.ToList();

                final.AddRange(text.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToList()
                        );

                text = String.Empty;
            }
            //final.RemoveAll(x => x == ' ');

            Console.WriteLine(String.Join(' ', final));
        }
    }
}
