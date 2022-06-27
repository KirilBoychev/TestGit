using System;
using System.Collections.Generic;
using System.Linq;

namespace T01.MealPlan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> meals = new Queue<string>
                (Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries));
            Stack<int> calories = new Stack<int>
                (Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            int counter = meals.Count;

            while (meals.Count > 0 && calories.Count > 0)
            {
                string meal = meals.Peek();
                int mealCal = 0;
                if (meal == "salad")
                {
                    mealCal = 350;
                }
                else if (meal == "soup")
                {
                    mealCal = 490;
                }
                else if (meal == "pasta")
                {
                    mealCal = 680;
                }
                else if (meal == "steak")
                {
                    mealCal = 790;
                }

                int sum = mealCal - calories.Peek();
                if (sum < 0)
                {
                    meals.Dequeue();
                    calories.Pop();
                    calories.Push(Math.Abs(sum));
                }
                else if (sum == 0)
                {
                    meals.Dequeue();
                    calories.Pop();
                }
                else
                {
                    
                    while (sum > 0)
                    {
                        calories.Pop();
                        if (calories.Count == 0)
                        {
                            break;
                        }
                        sum -= calories.Peek();
                    }

                    if (sum < 0 && calories.Count > 0)
                    {
                        meals.Dequeue();
                        calories.Pop();
                        calories.Push(Math.Abs(sum));
                    }
                    else if (sum == 0 && calories.Count > 0)
                    {
                        meals.Dequeue();
                        calories.Pop();
                    }
                    else if (calories.Count == 0)
                    {
                        meals.Dequeue();
                    }
                }
            }

            if (meals.Count == 0)
            {
                Console.WriteLine($"John had {counter} meals.");
                Console.WriteLine($"For the next few days, he can eat {string.Join(", ", calories)} calories.");
            }
            else
            {
                Console.WriteLine($"John ate enough, he had {counter - meals.Count} meals.");
                Console.WriteLine($"Meals left: {string.Join(", ", meals)}.");
            }
        }
    }
}
