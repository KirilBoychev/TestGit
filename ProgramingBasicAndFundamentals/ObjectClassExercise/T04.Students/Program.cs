using System;
using System.Collections.Generic;
using System.Linq;

namespace T04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> list = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string firstIndex = arr[0];
                string secondIndex = arr[1];
                double thirdIndex = double.Parse(arr[2]);

                Student currOne = new Student(firstIndex, secondIndex, thirdIndex);
                list.Add(currOne);
            }

            list = list.OrderByDescending(g => g.Grade).ToList();

            foreach (var student in list)
            {
                Console.WriteLine(student);
            }
        }
    }

    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}: {this.Grade:f2}";
        }
    }
}
