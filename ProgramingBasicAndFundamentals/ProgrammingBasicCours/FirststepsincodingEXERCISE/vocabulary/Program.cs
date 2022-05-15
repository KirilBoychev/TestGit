using System;

namespace vocabulary
{
    class Program
    {
        static void Main(string[] args)
        {
            int pen = int.Parse(Console.ReadLine());
            int marker = int.Parse(Console.ReadLine());
            int litersForBoard = int.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());
            double expenses1 = pen * 5.80;
            double expenses2 = marker * 7.20;
            double expenses3 = litersForBoard * 1.20;
            double expenses = expenses1 + expenses2 + expenses3;
            double sum = expenses - expenses * percent / 100;
            Console.WriteLine(sum);
        }
    }
}