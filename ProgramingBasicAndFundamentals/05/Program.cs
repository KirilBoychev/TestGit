using System;

namespace _05_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number = int.Parse(Console.ReadLine());

            //char firstLetter = 'a';
            //char lastLetter = 'z';

            //string castMethod = string.Empty;

            //for (char Alfabetic = firstLetter; Alfabetic <= lastLetter; Alfabetic++)
            //{
            //if (number.length == 3)
            //{

            //}


            int clicks = int.Parse(Console.ReadLine());
            string message = string.Empty;

            for (int i = 0; i < clicks; i++)
            {
                string digits = Console.ReadLine();
                int digitLength = digits.Length;
                int digit = digits[0] - '0';    // ASCII 
                int offset = (digit - 2) * 3;

                if (digit == 0)
                {
                    message += (char)(digit + 32);
                    continue;
                }

                if (digit == 8 || digit == 9)
                {
                    offset++;
                }
                int letterIndex = offset + digitLength - 1;
                message += (char)(letterIndex + 97);
            }

            Console.WriteLine(message);
        }
    }
}
