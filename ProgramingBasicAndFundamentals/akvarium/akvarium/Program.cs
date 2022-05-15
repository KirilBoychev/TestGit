using System;

namespace akvarium
{
    class Program
    {
        static void Main(string[] args)
        {
            int L = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            int H = int.Parse(Console.ReadLine());
            double SAND = double.Parse(Console.ReadLine());
            double sum = L * D * H * 0.001 * (1 - SAND/100);
            Console.WriteLine(sum);
        }
    }
}
