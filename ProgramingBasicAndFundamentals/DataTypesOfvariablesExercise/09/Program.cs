using System;
using System.Numerics;

namespace _09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var yield = uint.Parse(Console.ReadLine());
            
            BigInteger rest = 0;
            
            int counter = 0;
            if (yield >= 100)
            {
                while (yield >= 100)
                {
                    rest += yield - 26;
                    yield -= 10;
                    counter++;
                }
                if (yield < 100)
                {
                    rest -= 26;
                }
                Console.WriteLine(counter);
                Console.WriteLine($"{(BigInteger)rest}");
            }
            else
            {
                Console.WriteLine(counter);
                Console.WriteLine($"{(BigInteger)rest}");
            }
           
        }
    }
}
