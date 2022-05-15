using System;

namespace Yard
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double discount = 7.61 * 0.18 * area;
            double expenses = area * 7.61 * (1 - 0.18);
            Console.WriteLine("The final price is: " + expenses + " lv.");
            Console.WriteLine("The discount is: " + discount + " lv.");
        }
    }
}
