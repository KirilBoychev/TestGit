using System;

namespace Deposit
{
    class Program
    {
        static void Main(string[] args)
        {
            int sheets = int.Parse(Console.ReadLine());
            var sheetsforhour = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            var hours = (sheets / sheetsforhour) / days;
            Console.WriteLine(hours);
        }
    }
}