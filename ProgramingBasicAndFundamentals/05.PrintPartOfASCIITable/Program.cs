using System;

namespace _05.PrintPartOfASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstSign = int.Parse(Console.ReadLine());
            int lastSign = int.Parse(Console.ReadLine());

            for (int countOfChars = firstSign; countOfChars <= lastSign; countOfChars++)
            {
                Console.Write($"{(char)countOfChars} ");
            }
        }
    }
}
