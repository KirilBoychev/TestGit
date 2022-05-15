using System;

namespace _03.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int input = 0;
            int sum = input;
            while (sum < num)
            {
                input = int.Parse(Console.ReadLine());
                sum += input;
                if (sum >= num)
                {
                    break;
                }
            }
            Console.WriteLine(sum);

        }
    }
}
