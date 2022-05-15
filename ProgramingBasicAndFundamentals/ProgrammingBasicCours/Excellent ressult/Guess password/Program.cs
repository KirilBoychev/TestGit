using System;

namespace Guess_password
{
    class Program
    {
        static void Main(string[] args)
        {
            //INPUT FROM THE CONSOLE
            string Password = Console.ReadLine();

            //SOLVING THE PROBLEM
            if (Password == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else 
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
