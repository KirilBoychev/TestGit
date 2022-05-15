using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Person> list = new List<Person>();

            Family person;
            Person final;

            for (int i = 1; i <= n; i++)
            {
                string[] inputMember = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = inputMember[0];
                int age = int.Parse(inputMember[1]);

                Person personMember = new Person(name, age);
                
                person = new Family(list, personMember);
                person.AddMember(personMember);

                if (i == n)
                {
                    final = person.PersonGetOldestMember(list);
                    Console.WriteLine($"{final.Name} {final.Age}");
                }
            }
        }
    }

    class Family
    {
        public Family(List<Person> list, Person personMember)
        {
            this.ListOfPeople = list;
            this.AddMember(personMember);
            this.PersonGetOldestMember(list);
        }
        public List<Person> ListOfPeople { get; set; }
        public void AddMember(Person personMember)
        {
            personMember = new Person(personMember.Name, personMember.Age);
            ListOfPeople.Add(personMember);
        }
        public Person PersonGetOldestMember(List<Person> list)
        {
            list = list.OrderByDescending(x => x.Age).ToList();
            return list[0];
        }
    }

    class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
