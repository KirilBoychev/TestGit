using System;

namespace _01.ReadText
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            while (input != "Stop")
            {
                input = Console.ReadLine();
                if (input == "Stop")
                {
                    break;
                }
                Console.WriteLine(input);
            }
        }
    }
}
