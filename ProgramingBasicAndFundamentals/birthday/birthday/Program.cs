using System;

namespace birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            double pricestrawberry = double.Parse(Console.ReadLine());
            double banana = double.Parse(Console.ReadLine());
            double orange = double.Parse(Console.ReadLine());
            double malina = double.Parse(Console.ReadLine());
            double strawberry = double.Parse(Console.ReadLine());
            double st = pricestrawberry * strawberry;
            double ml = (malina * pricestrawberry) / 2;
            double or = (orange * ((pricestrawberry) / 2)) * 0.6;
            double bm = (banana * (pricestrawberry / 2) * 0.6) * 0.2;
            double sum = st + ml + or + bm;
            Console.WriteLine(sum);
        }
}
