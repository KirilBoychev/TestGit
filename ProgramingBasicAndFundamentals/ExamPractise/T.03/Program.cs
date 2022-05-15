using System;
using System.Collections.Generic;
using System.Linq;

namespace T._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Plant> plants = new List<Plant>();
            double rating = 0;

            for (int i = 0; i < n; i++)
            {
                string[] inputPlant = Console.ReadLine()
                    .Split("<->", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string namePlant = inputPlant[0];
                double rarity = double.Parse(inputPlant[1]);

                Plant currOne = new Plant(namePlant, rarity, rating);

                if (plants.Any(x => x.Name == namePlant))
                {
                    foreach (var plant in plants.Where(x => x.Name == namePlant))
                    {
                        plant.Rarity = rarity;
                    }
                    //plants = plants.Where(x => x.Rarity == rarity).ToList();
                    //plants = plants.Where(x => x.Rating == rating).ToList();
                }
                else
                {
                    plants.Add(currOne);
                }
            }
            
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Exhibition")
            {
                List<string> commandArr = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                for (int i = 0; i < commandArr.Count; i++)
                {
                    if (commandArr[i] == "-")
                    {
                        commandArr.RemoveAt(i);
                    }
                }
                
                if (commandArr[0] == "Rate:")
                {
                    if (plants.Any(x => x.Name == commandArr[1]))
                    {
                        foreach (var plant in plants.Where(x => x.Name == commandArr[1]))
                        {
                            plant.Counter++;
                            plant.Rating += double.Parse(commandArr[2]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }

                if (commandArr[0] == "Update:")
                {
                    if (plants.Any(x => x.Name == commandArr[1]))
                    {
                        foreach (var plant in plants.Where(x => x.Name == commandArr[1]))
                        {
                            plant.Rarity = double.Parse(commandArr[2]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }

                if (commandArr[0] == "Reset:")
                {
                    if (plants.Any(x => x.Name == commandArr[1]))
                    {
                        foreach (var plant in plants.Where(x => x.Name == commandArr[1]))
                        {
                            plant.Rating = 0;
                        }
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (var plant in plants)
            {
                Console.WriteLine($"- {plant.Name}; Rarity: {plant.Rarity}; Rating: {(plant.Rating / plant.Counter):f2}");
            }
        }
    }

    class Plant
    {
        public Plant(string name, double rarity, double rating)
        {
            this.Name = name;
            this.Rating = rating;
            this.Rarity = rarity;
            this.Counter = 0;
        }
        public string Name { get; set; }
        public double Rarity { get; set; }
        public double Rating { get; set; }
        public double Counter { get; set; }
    }
}
