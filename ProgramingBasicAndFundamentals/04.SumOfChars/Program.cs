using System;

namespace _04.SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int everyLine = 1; everyLine <= numberOfLines; everyLine++)
            {
                char lineAfterLine = char.Parse(Console.ReadLine());

                sum += lineAfterLine;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
