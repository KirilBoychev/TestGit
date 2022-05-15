using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string currentPass = string.Empty;

            for (int reverseIndex = username.Length - 1; reverseIndex >= 0; reverseIndex--)
            {
                currentPass += username[reverseIndex];
            }

            for (int k = 0; k < 4; k++)
            {
                string pass = Console.ReadLine();
                if (pass == currentPass)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    if (k == 3)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }
                }
            }
            
        }
    }
}
