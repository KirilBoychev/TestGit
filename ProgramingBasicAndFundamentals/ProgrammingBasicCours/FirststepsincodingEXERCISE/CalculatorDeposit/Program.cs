using System;

namespace CalculatorDeposit
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int term = int.Parse(Console.ReadLine());
            double lihva = double.Parse(Console.ReadLine());
            double sum = deposit + term * ((deposit * lihva / 100) / 12);
            Console.WriteLine(sum);
        } 
    }
}
