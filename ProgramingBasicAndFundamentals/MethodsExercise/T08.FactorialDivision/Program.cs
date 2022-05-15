using System;
using System.Numerics;

namespace T08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            BigInteger result = Factorial1(num1) / Factorial2(num2);
            Console.WriteLine($"{result:f2}");
        }

        static BigInteger Factorial1(int num1)
        {
            BigInteger factorial = 1;
            for (int i = 2; i <= num1; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        static BigInteger Factorial2(int num2)
        {

            BigInteger factorial = 1;
            for (int i = 2; i <= num2; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
