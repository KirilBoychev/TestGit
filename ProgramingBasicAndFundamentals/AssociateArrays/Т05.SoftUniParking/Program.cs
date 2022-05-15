using System;
using System.Collections.Generic;
using System.Linq;

namespace Т05.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> registered = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
                
                if (command[0] == "register")
                {
                    string username = command[1];
                    string licensePlateNumber = command[2];

                    if (registered.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                    else
                    {
                        registered[username] = licensePlateNumber;
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                }
                else if (command[0] == "unregister")
                {
                    string username = command[1];

                    if (!registered.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {

                    }
                }
            }
        }
    }
}
