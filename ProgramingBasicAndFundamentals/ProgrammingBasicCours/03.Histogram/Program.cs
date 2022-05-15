using System;

namespace _03.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum < 200)
                {
                    p1 += 1;
                }
                else if (currentNum >= 200 && currentNum < 400)
                {
                    p2 += 1;
                }
                else if (currentNum >=400 && currentNum < 600)
                {
                    p3 += 1;
                }
                else if (currentNum >= 600 && currentNum < 800)
                {
                    p4 += 1;
                }
                else if (currentNum >= 800 && currentNum <= 1000)
                {
                    p5 += 1;
                }
            }

            double sum = p1 + p2 + p3 + p4 + p5;

            double p1Percent = p1 * 100 / sum;
            double p2Percent = p2 * 100 / sum;
            double p3Percent = p3 * 100 / sum;
            double p4Percent = p4 * 100 / sum;
            double p5Percent = p5 * 100 / sum;

            Console.WriteLine($"{p1Percent:f2}%");
            Console.WriteLine($"{p2Percent:f2}%");
            Console.WriteLine($"{p3Percent:f2}%");
            Console.WriteLine($"{p4Percent:f2}%");
            Console.WriteLine($"{p5Percent:f2}%");
        }
    }
}
