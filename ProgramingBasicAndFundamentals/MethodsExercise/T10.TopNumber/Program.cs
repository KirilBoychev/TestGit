using System;

namespace T10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sequanceOfNumbers = int.Parse(Console.ReadLine());

            for (int eachNumber = 1; eachNumber <= sequanceOfNumbers; eachNumber++)
            {
                string number = eachNumber.ToString();
                if (DivisibleByEight(number) == true && OneOddDigit(number) == true)
                {
                    Console.WriteLine(number);
                }
            }

        }

        static bool DivisibleByEight(string number)
        {
            int sum = 0;
            
            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
            }
            if (sum % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool OneOddDigit(string number)
        {
            bool odd = false;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 == 1)
                {
                    odd = true;
                    break;
                }
                else
                {
                    odd = false;
                    continue;
                }
            }
            return odd;
        }
    }
}
