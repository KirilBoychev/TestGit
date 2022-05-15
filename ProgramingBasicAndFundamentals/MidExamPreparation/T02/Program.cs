using System;
using System.Linq;

namespace T02_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int counter = 0;
            string text = Console.ReadLine();

            while (text != "End")
            {
                int index = int.Parse(text);

                if (index > -1 && index < arr.Length)
                {
                    for (int i = 0; i < index; i++)
                    {
                        if (arr[i] != -1)
                        {
                            if (arr[index] >= arr[i])
                            {
                                arr[i] += arr[index];
                            }
                            else if (arr[index] < arr[i])
                            {
                                arr[i] -= arr[index];
                            }
                        }
                    }

                    for (int i = index + 1; i < arr.Length; i++)
                    {
                        if (arr[i] != -1)
                        {
                            if (arr[index] >= arr[i])
                            {
                                arr[i] += arr[index];
                            }
                            else if (arr[index] < arr[i])
                            {
                                arr[i] -= arr[index];
                            }
                        }
                    }
                    arr[index] = -1;
                    counter++;
                }

                text = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {counter} -> {string.Join(' ', arr)}");
        }
    }
}
