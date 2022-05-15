using System;

namespace SimpleCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string architect = Console.ReadLine();
            var projects = int.Parse(Console.ReadLine());
            var hours = projects * 3;
            Console.WriteLine("The architect " + architect + " will need " + hours + " hours to complete " + projects + " project/s.");
        }
    }
}
