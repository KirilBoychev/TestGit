using System;
using System.Linq;

namespace T01.MealPlan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int saladCalories = 350;
            const int soupCalories = 490;
            const int pastaCalories = 680;
            const int steakCalories = 790;

            string[] meals = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int[] caloriesPerDay = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < caloriesPerDay.Length; i++)
            {
                int currCalories = caloriesPerDay[i];

                for (int j = 0; j < meals.Length; j++)
                {
                    string currMeal = meals[j];
                    if (currMeal == "salad")
                    {
                        if (currCalories - saladCalories == 0)
                        {
                            currCalories -= saladCalories;
                            break;
                        }
                        else if (currCalories - saladCalories < 0)
                        {
                            int currCal = saladCalories - currCalories;
                            currCalories = 0;
                            break;
                        }
                    }
                    else if (currMeal == "soup")
                    {
                        currCalories -= soupCalories;
                    }
                    else if (currMeal == "pasta")
                    {
                        currCalories -= pastaCalories;
                    }
                    else if (currMeal == "steak")
                    {
                        currCalories -= steakCalories;
                    }
                }
            }
        }
    }
}
