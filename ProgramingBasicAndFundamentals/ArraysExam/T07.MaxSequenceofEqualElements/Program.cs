using System;
using System.Linq;

namespace T07.MaxSequenceofEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int counter = 0;
            int currentCounter = 0;
            //int index = 0;
            string num = string.Empty;

            for (int currentIndex = 0; currentIndex <= arrayInput.Length - 2; currentIndex++)
            {
                if (arrayInput[currentIndex] == arrayInput[currentIndex + 1])
                {
                    counter++;
                    if (counter > currentCounter)
                    {
                        currentCounter = counter;
                        num = arrayInput[currentIndex].ToString();
                    }
                }
                else
                {
                    counter = 0;
                }
            }
            for (int i = 0; i <= currentCounter; i++)
            {
                Console.Write($"{num} ");
            }


            }
        }
}
