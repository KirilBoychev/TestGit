using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double naem = double.Parse(Console.ReadLine());
            double sum = naem + 0.2 * naem + 0.2 * naem * (1 - 0.45) + naem / 3;
            Console.WriteLine(sum);

        }
    }
}
