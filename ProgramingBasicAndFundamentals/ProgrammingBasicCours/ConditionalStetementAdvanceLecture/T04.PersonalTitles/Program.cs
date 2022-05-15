using System;

namespace T04.PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string sex = Console.ReadLine();

            //////•	"mr." – мъж(пол 'm') на 16 или повече години
            //////•	"master" – момче(пол 'm') под 16 години
            //////•	"ms." – жена(пол 'f') на 16 или повече години
            //////•	"miss" – момиче(пол 'f') под 16 години
            switch (sex)
            {
                case "m":
                    if (age >= 16)
                    {
                        Console.WriteLine("Mr.");
                    }
                    else
                    {
                        Console.WriteLine("Master");
                    }
                    break;
                case "f":
                    if (age >= 16)
                    {
                        Console.WriteLine("Ms.");
                    }
                    else
                    {
                        Console.WriteLine("Miss");
                    }
                    break;
            }
        }
    }
}
