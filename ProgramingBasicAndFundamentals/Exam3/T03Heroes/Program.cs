using System;
using System.Collections.Generic;
using System.Linq;

namespace T03Heroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfHeroes = int.Parse(Console.ReadLine());

            List<Hero> list = new List<Hero>();

            for (int i = 0; i < countOfHeroes; i++)
            {
                string[] eveyHero = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string heroName = eveyHero[0];
                int hitPoints = int.Parse(eveyHero[1]);
                int manaPoints = int.Parse(eveyHero[2]);

                Hero currOne = new Hero(heroName, hitPoints, manaPoints);

                list.Add(currOne);
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandArr = command
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string action = commandArr[0];
                string heroName = commandArr[1];


                if (action == "CastSpell")
                {
                    double manaPoints = double.Parse(commandArr[2]);
                    string spellName = commandArr[3];
                    if (list.Any(y => y.ManaPoints >= manaPoints))
                    {
                        list.Where(x => x.Name == heroName).Where(y => y.ManaPoints >= manaPoints)
                        .Select(x => x.ManaPoints -= manaPoints).ToList();

                        foreach (var item in list.Where(x => x.Name == heroName).Where(y => y.ManaPoints >= manaPoints).ToList())
                        {
                            Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {item.ManaPoints} MP!");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (action == "TakeDamage")
                {
                    double damage = double.Parse(commandArr[2]);
                    string attacker = commandArr[3];

                    list.Where(x => x.Name == heroName).Select(x => x.HitPoints -= damage).ToList();


                    foreach (var item in list.Where(x => x.Name == heroName).Where(x => x.HitPoints > 0).ToList())
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {item.HitPoints} HP left!");
                        continue;
                    }

                    Console.WriteLine($"{heroName} has been killed by {attacker}!");
                    foreach (var item in list.Where(x => x.Name == heroName).ToList())
                    {
                        list.Remove(item);
                    }
                }
                else if (action == "Recharge")
                {
                    double mana = double.Parse(commandArr[2]);

                    foreach (var item in list.Where(x => x.Name == heroName).ToList())
                    {
                        list.Where(x => x.Name == heroName).Where(x => x.ManaPoints + mana > 200).Select(x => x.ManaPoints = 200).ToList();
                        list.Where(x => x.Name == heroName).Where(x => x.ManaPoints + mana <= 200).Select(x => x.ManaPoints += mana).ToList();
                        Console.WriteLine($"{heroName} healed for {mana} MP!");
                    }
                }
                else if (action == "Heal")
                {
                    double hit = double.Parse(commandArr[2]);

                    foreach (var item in list.Where(x => x.Name == heroName).ToList())
                    {
                        list.Where(x => x.Name == heroName).Where(x => x.HitPoints + hit > 100).Select(y => hit = 100.0 - y.HitPoints).ToList();
                        list.Where(x => x.Name == heroName).Where(x => x.HitPoints + hit <= 100).Select(x => x.HitPoints += hit).ToList();
                        
                        Console.WriteLine($"{heroName} recharged for {hit} MP!");
                        list.Where(x => x.Name == heroName).Where(x => x.HitPoints + hit > 100).Select(x => x.HitPoints = 100).ToList();

                    }
                }
            }

            foreach (var item in list)
            {
                Console.WriteLine($"{item.Name}");
                Console.WriteLine($"  HP: {item.HitPoints}");
                Console.WriteLine($"  MP: {item.ManaPoints}");
            }
        }
    }

    class Hero
    {
        public Hero(string name, double hitPoints, double manaPoints)
        {
            this.Name = name;
            this.HitPoints = hitPoints;
            this.ManaPoints = manaPoints;
        }
        public string Name { get; set; }
        public double HitPoints { get; set; }
        public double ManaPoints { get; set; }
    }
}
