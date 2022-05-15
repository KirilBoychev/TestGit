using System;

namespace _11.MultiplicationTable_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int startNum = int.Parse(Console.ReadLine());

            if (startNum <= 10)
            {
                for (int i = startNum; i < 11; i++)
                {
                    Console.WriteLine($"{number} X {i} = {number*i}");
                }
            }
            else
            {
                Console.WriteLine($"{number} X {startNum} = {startNum * number}");
            }
        }
    }
}
