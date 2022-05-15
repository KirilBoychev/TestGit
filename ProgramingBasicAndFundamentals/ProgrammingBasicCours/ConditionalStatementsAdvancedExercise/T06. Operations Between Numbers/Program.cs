using System;

namespace T06._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char symbol = Console.ReadLine()[0];

            double result = 0;

            switch (symbol)
            {
                case '+':
                    result = n1 + n2;
                    break;
                case '-':
                    result = n1 - n2;
                    break;
                case '*':
                    result = n1 * n2;
                    break;
                case '/':
                    double n3 = Convert.ToDouble(n2);
                    if (n3 != 0)
                    {
                        result = n1 / n3;
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    break;
                case '%':
                    if (n2 != 0)
                    {
                        result = n1 % n2;
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    break;
            }

            if ((symbol == '+') || (symbol == '-') || (symbol == '*'))
            {
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} {symbol} {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} {symbol} {n2} = {result} - odd");
                }
            }
            else if (symbol == '/' && result != 0)
            {
                Console.WriteLine($"{n1} {symbol} {n2} = {result:f2}");
            }
            else if (symbol == '%' && result != 0)
            {
                Console.WriteLine($"{n1} {symbol} {n2} = {result}");
            }

        }
    }
}
