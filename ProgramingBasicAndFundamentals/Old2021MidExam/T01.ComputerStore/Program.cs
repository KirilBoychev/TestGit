using System;
using System.Linq;

namespace T01.ComputerStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0;
            double taxes = 0;

            while (input != "special" && input != "regular")
            {
                double inputDouble = double.Parse(input);

                if (inputDouble < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    sum += inputDouble;
                }
                
                input = Console.ReadLine();
            }

            taxes = 0.2 * sum;
            
            double totalSum = sum + taxes;

            if (input == "special")
            {
                if (totalSum == 0)
                {
                    Console.WriteLine("Invalid order!");
                }
                else
                {
                    totalSum *= 0.9;
                    Console.WriteLine("Congratulations you've just bought a new computer!");
                    Console.WriteLine($"Price without taxes: {sum:f2}$");
                    Console.WriteLine($"Taxes: {taxes:f2}$");
                    Console.WriteLine("-----------");
                    Console.WriteLine($"Total price: {totalSum:f2}$");
                }
            }
            else
            {
                if (sum == 0)
                {
                    Console.WriteLine("Invalid order!");
                }
                else
                {
                    Console.WriteLine("Congratulations you've just bought a new computer!");
                    Console.WriteLine($"Price without taxes: {sum:f2}$");
                    Console.WriteLine($"Taxes: {taxes:f2}$");
                    Console.WriteLine("-----------");
                    Console.WriteLine($"Total price: {totalSum:f2}$");
                }
            }
            


            //char[] charArr = input.Split(' ').Select(char.Parse).ToArray();
            //for (int index = 0; index < charArr.Length; index++)
            //{
            //    if (!char.IsDigit(charArr[index]))
            //    {
            //        flag = true;
            //        break;
            //    }
            //}
            //if (flag == true)
            //{
            //    Console.WriteLine("");
            //}
        }
    }
}
