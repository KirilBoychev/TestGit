using System;
using System.Linq;
using System.Collections.Generic;

namespace T01.CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Employee> listOfEmploys = new List<Employee>();

            Loop(n, listOfEmploys);

            List<Employee> employeeWithBiggestAvarageSalary = new List<Employee>();

            double previousSum = 0;
            int counter = 1;
            string depart = string.Empty;

            foreach (var employee in listOfEmploys)
            {
                double sum = 0;
                counter = 1;
                
                if (listOfEmploys.Any(x => x.Department == employee.Department))
                {
                    if (true)
                    {
                        counter++;
                        foreach (var emp1 in listOfEmploys.Where(x => x.Department == employee.Department))
                        {
                            sum += emp1.Salary;
                        }
                    }
                    sum /= (double)counter;
                }
                

                if (previousSum < sum)
                {
                    previousSum = sum;
                    depart = employee.Department;
                }
            }

            foreach (var emp in listOfEmploys.Where(x => x.Department == depart))
            {
                employeeWithBiggestAvarageSalary.Add(emp);
            }

            employeeWithBiggestAvarageSalary = employeeWithBiggestAvarageSalary.OrderByDescending(x => x.Salary).ToList();

            Console.WriteLine($"Highest Average Salary: {depart}");

            foreach (var item in employeeWithBiggestAvarageSalary)
            {
                Console.WriteLine($"{item.Name:f2} {item.Salary:f2}");
            }
        }

        static void Loop(int n, List<Employee> listOfEmploys)
        {
            for (int i = 0; i < n; i++)
            {
                string[] everySingleEmployee = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = everySingleEmployee[0];
                double salary = double.Parse(everySingleEmployee[1]);
                string department = everySingleEmployee[2];

                Employee employeeObject = new Employee(name, salary, department);

                listOfEmploys.Add(employeeObject);
            }
        }
    }

    class Employee
    {
        public Employee(string name, double salary, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Department = department;
        }

        //public Employee(string name, double salary)
        //{
        //    this.Name = name;
        //    this.Salary = salary;
        //}

        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
    }
}
