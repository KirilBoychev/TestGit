using System;
using System.Collections.Generic;
using System.Linq;

namespace T06.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            int counter = 0;

            Dictionary<string, Dictionary<int, List<string>>> courseStudent = new Dictionary<string, Dictionary<int, List<string>>>();
            Dictionary<int, List<string>> dict = new Dictionary<int, List<string>>();

            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArr = command
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string course = commandArr[0];
                string name = commandArr[1];

                List<string> names = new List<string>();


                if (courseStudent.ContainsKey(course))
                {
                    dict[0] = courseStudent[course][1];
                    counter = int.Parse(dict.Contains());
                    //List<string> names = new List<string>();
                    counter++;
                    names.Add(name);
                    names = courseStudent[course][1];
                    
                }
                else
                {
                    
                    names.Add(name);
                    counter = 1;
                    dict.Add(counter, names);
                    courseStudent.Add(course, dict);
                }
            }

            foreach (var item in courseStudent)
            {
                Console.WriteLine($"{item.Key}: {item.Value[0]}");
                foreach (var value in item.Value[1])
                {
                    Console.WriteLine($"-- {value}");
                }
            }
        }
    }
}
