using System;

namespace t01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(SmallestInteger(number));
        }

        static int SmallestInteger(int number)
        {
            int smallInt = int.MaxValue;
            if (number <= smallInt)
            {
                smallInt = number;
            }

            for (int i = 1; i < 3; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (number <= smallInt)
                {
                    smallInt = number;
                }
            }
            return smallInt;
        }
    }
}
