using System;

namespace T04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int start = 6;
            const int end = 10;
            const int minDigitLenght = 2;
            string password = Console.ReadLine();
            
            
            if (Passlenght(password, start, end) == false)
            {
                Console.WriteLine($"Password must be between {start} and {end} characters");
            }
            if (LettersAndDigits(password) == false)
            {
                Console.WriteLine($"Password must consist only of letters and digits");
            }
            if (MinTwoDigits(password) == false)
            {
                Console.WriteLine($"Password must have at least {minDigitLenght} digits");
            }
            if (Passlenght(password, start, end) == true && LettersAndDigits(password) == true & MinTwoDigits(password) == true)
            {
                Console.WriteLine("Password is valid");
            }

        }
        static bool Passlenght(string pass, int start, int end)
        {
            if (pass.Length >= start && pass.Length <= end)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool LettersAndDigits(string pass)
        {
            foreach (var ch in pass)
            {
                if (!Char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }

        static bool MinTwoDigits(string pass)
        {
            int counter = 0;
            foreach (var index in pass)
            {
                if (char.IsDigit(index))
                {
                    counter++;
                }
            }
            if (counter > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
