using System;
using System.Linq;

namespace T01.DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfVariable = Console.ReadLine();

            if (typeOfVariable == "int")
            {
                int intNum = int.Parse(Console.ReadLine());
                Console.WriteLine(intNum * 2);
            }
            else if (typeOfVariable == "real")
            {
                double realNum = double.Parse(Console.ReadLine());
                Console.WriteLine($"{(realNum * 1.5):f2}");
            }
            else
            {
                string text = Console.ReadLine();
                Console.WriteLine($"${text}$");
            }


        }
    }
}
