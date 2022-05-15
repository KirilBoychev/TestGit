using System;

namespace _04.Sequence2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int input = 0;
            
            while (input <= number)
            {
                input = 2 * input + 1;
                
                if (input > number)
                {
                    break;
                }
                Console.WriteLine(input);
            }
        }
    }
}
