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
                string[] inputArr = input
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

            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputArr = input
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = inputArr[0];

                if (command == "Plunder")
                {
                    string city = inputArr[1];
                    int population = int.Parse(inputArr[2]);
                    int gold = int.Parse(inputArr[3]);

                    foreach (var town in cities.Where(s => s.City == city).ToList())
                    {
                        town.Population -= population;
                        town.Gold -= gold;
                        Console.WriteLine($"{city} plundered! {gold} gold stolen, {population} citizens killed.");
                    }

                    foreach (var town in cities.Where(s => s.Population <= 0).ToList())
                    {
                        cities.Remove(town);
                        Console.WriteLine($"{city} has been wiped off the map!");
                        continue;
                    }
                    foreach (var town in cities.Where(s => s.Gold <= 0).ToList())
                    {
                        cities.Remove(town);
                        Console.WriteLine($"{city} has been wiped off the map!");
                    }
                }
                else if (command == "Prosper")
                {
                    string city = inputArr[1];
                    int gold = int.Parse(inputArr[2]);

                    foreach (var town in cities.Where(s => s.City == city))
                    {
                        if (gold > 0)
                        {
                            town.Gold += gold;
                            Console.WriteLine($"{gold} gold added to the city treasury. {city} now has {town.Gold} gold.");
                            continue;
                        }
                        Console.WriteLine($"Gold added cannot be a negative number!");
                    }
                }
            }

            Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
            foreach (var city in cities)
            {
                Console.WriteLine($"{city.City} -> Population: {city.Population} citizens, Gold: {city.Gold} kg");
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
