using System;

namespace _03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Allhumans = int.Parse(Console.ReadLine());
            int capacityElevator = int.Parse(Console.ReadLine());

            double courseCount = (double) Allhumans / capacityElevator;
            Console.WriteLine($"{Math.Ceiling(courseCount)}");
        }
    }
}
