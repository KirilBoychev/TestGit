using System;

namespace T11.MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            char @operator = char.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            MathOperator(num1, @operator, num2);
        }

        static void MathOperator(int num1, char @operator, int num2)
        {
            int sum = 0;

            switch (@operator)
            {
                case '+':
                    sum = num1 + num2;
                    break;
                case '-':
                    sum = num1 - num2;
                    break;
                case '*':
                    sum = num1 * num2;
                    break;
                case '/':
                    sum = num1 / num2;
                    break;
            }  
            Console.WriteLine(sum); ;
        }
    }
}
