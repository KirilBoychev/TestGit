using System;
using System.Collections.Generic;
using System.Linq;

namespace T03Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cities> cities = new List<Cities>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Sail")
            {
                string[] inputArr = Console.ReadLine()
                    .Split("||", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string city = inputArr[0];
                int population = int.Parse(inputArr[1]);
                int gold = int.Parse(inputArr[2]);

                Cities currCity = new Cities(city, population, gold);

                if (cities.Any(x => x.City == city))
                {
                    cities.Where(x => x.City == city).Select(x => x.Population += population).ToList();
                    cities.Where(x => x.City == city).Select(x => x.Gold += gold).ToList();
                }
                else
                {
                    cities.Add(currCity);
                }
            }
            foreach (var city in cities)
            {
                Console.WriteLine($"{city.Gold} {city.Population} {city.City}");
            }
        }
    }

    class Cities
    {
        public Cities(string city, int population, int gold)
        {
            this.City = city;
            this.Population = population;
            this.Gold = gold;
        }
        public string City { get; set; }
        public int Population { get; set; }
        public int Gold { get; set; }
    }
}
