using System;

namespace Т05.AddandSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstInt = int.Parse(Console.ReadLine());
            int secondInt = int.Parse(Console.ReadLine());
            int thirdInt = int.Parse(Console.ReadLine());

            int sum = SumFirstAndSecond(firstInt, secondInt);
            
            Console.WriteLine(SubstractSumAndThird(sum, thirdInt));
        }

        static int SumFirstAndSecond(int firstInt, int secondInt)
        {
            int sum = firstInt + secondInt;
            return sum;
        }

        static int SubstractSumAndThird(int sum, int thirdInt)
        {
            int rezult = sum - thirdInt;
            return rezult;
        }
    }
}
