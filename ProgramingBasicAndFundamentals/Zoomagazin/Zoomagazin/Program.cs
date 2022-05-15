using System;

namespace Zoomagazin
{
    class Program
    {
        static void Main(string[] args)
        {
            var dogs = int.Parse(Console.ReadLine());
            var otheranimals = int.Parse(Console.ReadLine());
            var sum = dogs * 2.5 + otheranimals * 4;
            Console.WriteLine(sum + " lv.");
        }
    }
}
