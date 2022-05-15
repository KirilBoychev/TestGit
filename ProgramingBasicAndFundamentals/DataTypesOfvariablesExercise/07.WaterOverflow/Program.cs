using System;

namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte countOfAttemps = byte.Parse(Console.ReadLine());

            long totalSum = 0l;
            for (int i = 0; i < countOfAttemps; i++)
            {
                short everyAttemp = short.Parse(Console.ReadLine());
                totalSum += everyAttemp;
                if (totalSum <= 255)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                    totalSum -= everyAttemp;
                }
            }
            Console.WriteLine(totalSum);
        }
    }
}
