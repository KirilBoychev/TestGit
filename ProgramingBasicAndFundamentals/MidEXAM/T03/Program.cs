using System;
using System.Collections.Generic;
using System.Linq;

namespace T03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputInt = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int index = int.Parse(Console.ReadLine());
            string cheapExpensive = Console.ReadLine();

            int sumLeft = 0;
            int sumRight = 0;

            string position = string.Empty;
            int sumTotal = 0;

            if (index > 0 && index < inputInt.Count - 1)
            {
                if (cheapExpensive == "cheap")
                {
                    for (int i = 0; i < index; i++)
                    {
                        if (inputInt[i] < inputInt[index])
                        {
                            sumLeft += inputInt[i];
                        }
                    }
                    for (int i = index + 1; i < inputInt.Count; i++)
                    {
                        if (inputInt[i] < inputInt[index])
                        {
                            sumRight += inputInt[i];
                        }
                    }
                    if (sumLeft >= sumRight)
                    {
                        position = "Left";
                        sumTotal = sumLeft;
                    }
                    else
                    {
                        position = "Right";
                        sumTotal = sumRight;
                    }
                }
                else if (cheapExpensive == "expensive")
                {
                    for (int i = 0; i < index; i++)
                    {
                        if (inputInt[i] >= inputInt[index])
                        {
                            sumLeft += inputInt[i];
                        }
                    }
                    for (int i = index + 1; i < inputInt.Count; i++)
                    {
                        if (inputInt[i] >= inputInt[index])
                        {
                            sumRight += inputInt[i];
                        }
                    }
                    if (sumLeft >= sumRight)
                    {
                        position = "Left";
                        sumTotal = sumLeft;
                    }
                    else
                    {
                        position = "Right";
                        sumTotal = sumRight;
                    }
                }
            }

            Console.WriteLine($"{position} - {sumTotal}");

        }
    }
}
