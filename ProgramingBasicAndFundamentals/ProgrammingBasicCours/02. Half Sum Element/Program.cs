using System;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                sum += numbers;
                if (numbers > maxNum)
                {
                    maxNum = numbers;
                }

            }


            int sumWithoutTheMax = sum - maxNum;
            int difference = Math.Abs(sumWithoutTheMax - maxNum);
            if (sumWithoutTheMax == maxNum)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {sumWithoutTheMax}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {difference}"); ;
            }
        }
    }
}
