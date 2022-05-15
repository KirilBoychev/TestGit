using System;

namespace Excellent_ressult
{
    class Program
    {
        static void Main(string[] args)
        {
            double evaluation = double.Parse(Console.ReadLine());
            if (evaluation >= 5.5)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
