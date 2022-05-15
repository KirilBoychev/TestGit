using System;

namespace Food_for_cat_and_dogs
{
    class Program
    {
        static void Main(string[] args)
        {
            int countDogFood = int.Parse(Console.ReadLine());
            int countCatFood = int.Parse(Console.ReadLine());
            double expenses = countCatFood * 4 + countDogFood * 2.5;
            Console.WriteLine(expenses + " lv.");
        }
    }
}
