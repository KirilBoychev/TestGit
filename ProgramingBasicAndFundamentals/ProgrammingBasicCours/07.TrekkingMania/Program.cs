using System;

namespace _07.TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfGroups = int.Parse(Console.ReadLine());
            double percentMusala = 0.0;
            double percentMonblan = 0.0;
            double percentKilimandjaro = 0.0;
            double percentK2 = 0.0;
            double percentEverest = 0.0;

            for (int i = 0; i < countOfGroups; i++)
            {
                int everySingleGroup = int.Parse(Console.ReadLine());

                if (everySingleGroup <= 5)
                {
                    percentMusala += everySingleGroup;
                }
                else if (everySingleGroup > 5 && everySingleGroup <= 12)
                {
                    percentMonblan += everySingleGroup;
                }
                else if (everySingleGroup > 12 && everySingleGroup <= 25)
                {
                    percentKilimandjaro += everySingleGroup;
                }
                else if (everySingleGroup > 25 && everySingleGroup <=40)
                {
                    percentK2 += everySingleGroup;
                }
                else if (everySingleGroup > 40)
                {
                    percentEverest += everySingleGroup;
                }
            }

            double sum = percentMusala + percentMonblan + percentKilimandjaro + percentK2 + percentEverest;

            percentMusala = percentMusala * 100 / sum;
            percentMonblan = percentMonblan * 100 / sum;
            percentKilimandjaro = percentKilimandjaro * 100 / sum;
            percentK2 = percentK2 * 100 / sum;
            percentEverest = percentEverest * 100 / sum;

            Console.WriteLine($"{percentMusala:f2}%");
            Console.WriteLine($"{percentMonblan:f2}%");
            Console.WriteLine($"{percentKilimandjaro:f2}%");
            Console.WriteLine($"{percentK2:f2}%");
            Console.WriteLine($"{percentEverest:f2}%");
            
        }
    }
}
