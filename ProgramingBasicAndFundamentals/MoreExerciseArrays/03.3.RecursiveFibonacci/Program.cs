using System;

namespace _03._3.RecursiveFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int FibonachiNumberPlece = int.Parse(Console.ReadLine());

            int[] arr = new int[FibonachiNumberPlece];
            int sum = 0;

            for (int everyFibonachiNum = 0; everyFibonachiNum < FibonachiNumberPlece; everyFibonachiNum++)
            {
                if (everyFibonachiNum == 0)
                {
                    arr[0] = 1;
                }
                else if (everyFibonachiNum == 1)
                {
                    arr[1] = 1;
                }
                else
                {
                    arr[everyFibonachiNum] = arr[everyFibonachiNum - 2] + arr[everyFibonachiNum - 1];
                }
                sum = arr[everyFibonachiNum];
            }

            Console.WriteLine(sum);
        }
    }
}
