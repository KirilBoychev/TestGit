using System;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string text = Convert.ToString(number);
            int n = text.Length;
            int factorial = 1;
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                char num = text[text.Length - i];
                int num1 = (int)Char.GetNumericValue(num);
                for (int j = 1; j <= num1; j++)
                {
                    factorial *= j;
                }
                sum += factorial;
                factorial = 1;
            }
            if (sum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
