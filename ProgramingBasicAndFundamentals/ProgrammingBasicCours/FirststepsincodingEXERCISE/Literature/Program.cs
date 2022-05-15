using System;

namespace Literature
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPagesInBook = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int countDays = int.Parse(Console.ReadLine());
            int hours = countPagesInBook / pagesPerHour;
            int days = hours / countDays;
            Console.WriteLine(days);
        }
    }
}
