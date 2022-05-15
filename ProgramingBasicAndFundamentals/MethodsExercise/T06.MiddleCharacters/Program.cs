using System;

namespace T06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            CountOfIndexes(text);
        }

        static void CountOfIndexes(string text)
        {
            if (text.Length % 2 == 0)
            {
                Console.WriteLine($"{text[(text.Length - 1) / 2]}{text[(text.Length - 1) / 2 + 1]}");
            }
            else
            {
                Console.WriteLine($"{text[text.Length / 2]}");
            }
        }
    }
}
