using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.HeroesOfCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Hero> list = new List<Hero>();

            for (int i = 0; i < n; i++)
            {
                string[] commandArr = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = commandArr[0];
                int hit = int.Parse(commandArr[1]);
                int mana = int.Parse(commandArr[2]);

                if (hit > 100)
                {
                    hit = 100;
                }
                if (mana > 200)
                {
                    mana = 200;
                }

                Hero currOne = new Hero(name, hit, mana);

                list.Add(currOne);
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandArr = command
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string commandName = commandArr[0];
                string heroName = commandArr[1];

                if (commandName == "CastSpell")
                {
                    int mana = int.Parse(commandArr[2]);
                    string spellName = commandArr[3];
                    foreach (var item in list.Where(x => x.Name == heroName).ToList())
                    {
                        if (item.ManaPoints - mana >= 0)
                        {
                            item.ManaPoints -= mana;
                            Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {item.ManaPoints} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                        }
                        break;
                    }
                }
                else if (commandName == "TakeDamage")
                {
                    int damage = int.Parse(commandArr[2]);
                    string attacker = commandArr[3];
                    foreach (var item in list.Where(s => s.Name == heroName))
                    {
                        if (item.HitPoints - damage < 0)
                        {
                            list.Remove(item);
                            Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        }
                        else
                        {
                            item.HitPoints -= damage;
                            Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {item.HitPoints} HP left!");
                        }
                        break;
                    }
                }
                else if (commandName == "Recharge")
                {
                    int additionalManaPoints = int.Parse(commandArr[2]);
                    foreach (var item in list.Where(s => s.Name == heroName))
                    {
                        if (item.ManaPoints + additionalManaPoints > 200)
                        {
                            additionalManaPoints = 200 - item.ManaPoints;
                        }
                        item.ManaPoints += additionalManaPoints;
                        Console.WriteLine($"{heroName} recharged for {additionalManaPoints} MP!");
                        break;
                    }
                }
                else if (commandName == "Heal")
                {
                    int additionalHitPoints = int.Parse(commandArr[2]);
                    foreach (var item in list.Where(x => x.Name == heroName))
                    {
                        if (additionalHitPoints + item.HitPoints > 100)
                        {
                            additionalHitPoints = 100 - item.HitPoints;
                        }
                        item.HitPoints += additionalHitPoints;
                        Console.WriteLine($"{heroName} healed for {additionalHitPoints} HP!");
                        break;
                    }
                }
            }

            //list = list.OrderByDescending(x => x.HitPoints).ThenBy(x => x.Name).ToList();
            

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
        public Hero(string name, int hit, int mana)
        {
            this.Name = name;
            this.HitPoints = hit;
            this.ManaPoints = mana;
        }
        public string Name { get; set; }
        public int HitPoints { get; set; }
        public int ManaPoints { get; set; }
    }
}
