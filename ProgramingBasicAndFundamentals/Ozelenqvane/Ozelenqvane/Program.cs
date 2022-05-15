using System;

namespace Ozelenqvane
{
    class Program
    {
        static void Main(string[] args)
        {
            var m2 = double.Parse(Console.ReadLine());
            var lv = m2 * 7.61;
            var ots = lv * 18 / 100;
            var kraen = lv - ots;
            Console.WriteLine("The final price is " + kraen + " lv.");
            Console.WriteLine("The discount is: " + ots + " lv.");
        }
    }
}
