
using System;

namespace Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int vegan = int.Parse(Console.ReadLine());
            double sum = chicken * 10.35 + fish * 12.40 + vegan * 8.15;
            double sumdes = 0.2 * sum;
            double sum3 = sum + sumdes + 2.5;
            Console.WriteLine(sum3);
        }
    }
}
