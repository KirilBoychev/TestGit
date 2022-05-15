using System;

namespace INCH_to_SM
{
    class Program
    {
        static void Main(string[] args)
        {
            var INCH = double.Parse(Console.ReadLine());
            var SM = INCH * 2.54; ;
            Console.WriteLine(SM);
        }
    }
}
