using System;

namespace _09.SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var countOfOddNumbers = int.Parse(Console.ReadLine());

            //int counter = 0;
            int sum = 0;

            //for (int i = 1; i <= 100; i += 2)
            //{
            //    counter++;
            //    if (counter <= countOfOddNumbers)
            //    {
            //        Console.WriteLine(i);
            //        sum += i;
            //    }
            //}
            for (var i = 0; i < countOfOddNumbers; i++)
            {
                int currentOddNumber = 1 + i * 2;
                Console.WriteLine(currentOddNumber);
                sum += currentOddNumber;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
