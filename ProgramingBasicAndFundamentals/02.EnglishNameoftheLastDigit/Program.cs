using System;

namespace _02.EnglishNameoftheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string numberText = Convert.ToString(number);
            char lastFigure = numberText[numberText.Length - 1];
            
            if (lastFigure == '1')
            {
                Console.WriteLine("one");
            }
            else if(lastFigure == '2')
            {
                Console.WriteLine("two");
            }
            else if (lastFigure == '3')
            {
                Console.WriteLine("three");
            }
            else if (lastFigure == '4')
            {
                Console.WriteLine("four");
            }
            else if (lastFigure == '5')
            {
                Console.WriteLine("five");
            }
            else if (lastFigure == '6')
            {
                Console.WriteLine("six");
            }
            else if (lastFigure == '7')
            {
                Console.WriteLine("seven");
            }
            else if (lastFigure == '8')
            {
                Console.WriteLine("eight");
            }
            else if (lastFigure == '9')
            {
                Console.WriteLine("nine");
            }
            else if (lastFigure == '0')
            {
                Console.WriteLine("zero");
            }
        }
    }
}
