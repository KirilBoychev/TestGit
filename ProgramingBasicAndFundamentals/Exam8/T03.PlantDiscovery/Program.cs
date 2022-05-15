using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Plant> plants = new List<Plant>();

            for (int i = 0; i < n; i++)
            {
                string[] commandArr = Console.ReadLine()
                    .Split("<->", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string plantName = commandArr[0];
                int rarity = int.Parse(commandArr[1]);
                double rating = 0;
                int counter = 0;

                Plant currOne = new Plant(plantName, rarity, rating, counter);

                foreach (var plant in plants.Where(x => x.Name == plantName).ToList())
                {
                    plant.Rarity = rarity;
                    continue;
                }
                plants.Add(currOne);
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Exhibition")
            {
                string[] commandArr = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string com = commandArr[0];
                string plantName = commandArr[1];

                if (plants.Any(x => x.Name == plantName))
                {
                    if (com == "Rate:")
                    {
                        string tire = commandArr[2];
                        double rating = double.Parse(commandArr[3]);
                        foreach (var plant in plants.Where(x => x.Name == plantName).ToList())
                        {
                            plant.Rating += rating;
                            plant.Counter++;
                        }
                    }
                    else if (com == "Update:")
                    {
                        string tire = commandArr[2];
                        int newRarity = int.Parse(commandArr[3]);
                        foreach (var plant in plants.Where(x => x.Name == plantName).ToList())
                        {
                            plant.Rarity = newRarity;
                        }
                    }
                    else if (com == "Reset:")
                    {
                        foreach (var plant in plants.Where(x => x.Name == plantName).ToList())
                        {
                            plant.Rating = 0;
                            plant.Counter = 0;
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"error");
                }
            }

            Console.WriteLine($"Plants for the exhibition:");
            foreach (var plant in plants)
            {
                if (plant.Counter > 0)
                {
                    plant.Rating /= (double)plant.Counter;
                }
                Console.WriteLine($"- {plant.Name}; Rarity: {plant.Rarity}; Rating: {plant.Rating:f2}");
            }
        }
    }

    class Plant
    {
        public Plant(string name, int rarity, double rating, int counter)
        {
            this.Name = name;
            this.Rarity = rarity;
            this.Rating = rating;
            this.Counter = counter;
        }
        public string Name { get; set; }
        public int Rarity { get; set; }
        public double Rating { get; set; }
        public int Counter { get; set; }
    }
}
