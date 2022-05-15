using System;

namespace T01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            decimal PackageflourPrize = decimal.Parse(Console.ReadLine());
            decimal singleEggPrize = decimal.Parse(Console.ReadLine());
            decimal singleApronPrize = decimal.Parse(Console.ReadLine());

            decimal sum = 0;
            int flourDiscount = 0;
            if (studentCount >= 5)
            {
                flourDiscount = studentCount / 5;
            }
            sum = (decimal)(singleApronPrize * Math.Ceiling(studentCount * 1.2m) + singleEggPrize * 10m * studentCount + PackageflourPrize * (studentCount - flourDiscount));
            
            decimal difference = Math.Abs(budget - sum);
            if (budget >= sum)
            {
                Console.WriteLine($"Items purchased for {sum:f2}$.");
            }
            else
            {
                Console.WriteLine($"{difference:f2}$ more needed.");
            }
        }
    }
}
