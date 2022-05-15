using System;

namespace INCHtoSM
{
    class Program
    {
        static void Main(string[] args)
        {
            var inch = int.Parse(Console.ReadLine());
            var sm = inch * 2.54;
            Console.WriteLine(sm);
        }
    }
}
