using System;
using System.Collections.Generic;
using System.Linq;

namespace T07
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<PersonInformation> persons = new List<PersonInformation>();

            while (command != "End")
            {
                string[] currentObject = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = currentObject[0];
                string iD = currentObject[1];
                int age = int.Parse(currentObject[2]);

                PersonInformation currentPerson = new PersonInformation(name, iD, age);
                PersonInformation searchPerson = persons.FirstOrDefault(x => x.ID == iD);
                if (persons.Any(x => x.ID == iD))
                {
                    searchPerson.Name = name;
                    searchPerson.Age = age;
                    //foreach (var person in persons.Where(y => y.ID == iD))
                    //{
                    //    person.Name = name;
                    //    person.Age = age;
                    //}
                }
                else
                {
                    persons.Add(currentPerson);
                }

                command = Console.ReadLine();
            }

            persons = persons.OrderBy(x => x.Age).ToList();

            foreach (var person in persons)
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }

    class PersonInformation
    {
        public PersonInformation(string name, string iD, int age)
        {
            this.Name = name;
            this.ID = iD;
            this.Age = age;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
}
