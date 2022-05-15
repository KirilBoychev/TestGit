using System;

namespace T10.Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 0 || number > 0 && number < 100 || number > 200)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
