using System;

namespace ConsoleApp3
{
    internal class Program
    {
        public static object Print { get; private set; }

        static void Main(string[] args)
        {
            //bool isTrue = true;
            //int value = int.Parse(isTrue);
            //Console.WriteLine(value);
            //for (int i = 10; i > 3; i -= 2)
            //{
            //    Console.Write($"{i}");
            //}

            int a = 5;
            int b = a++;
            int c = ++a;
            Console.WriteLine(c);

            
        }

        public void PrintText(string text)
        {
            Console.WriteLine("A love" + text);
        }
    }
}
