using System;

namespace _08.LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
                    

                for (int s = 0; s < n; s++)
                {
                int number = int.Parse(Console.ReadLine());
                sum1 += number;
                }

                for (int f = n; f < n*2; f++)
                {
                int number2 = int.Parse(Console.ReadLine());
                sum2 += number2;
                }

            int difference = Math.Abs(sum2 - sum1);

            if (difference != 0)
            {
                Console.WriteLine($"No, diff = {difference}");
            }
            else
            {
                Console.WriteLine($"Yes, sum = {sum1}");
            }
            
        }
    }
}
