using System;

namespace _04.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            char lastLetter = text[text.Length - 1];

            for (int i = 0; i <= text.Length - 1; i++)
            {
                lastLetter = text[(text.Length - 1) - i];
                Console.Write(lastLetter);
            }
        }
    }
}
