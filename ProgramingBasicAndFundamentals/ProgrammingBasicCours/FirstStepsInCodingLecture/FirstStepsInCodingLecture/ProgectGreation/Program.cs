using System;

namespace ProgectGreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());
            double hour = projects * 3;
            string arch = "The architect " + name + " will need " + hour + " hours to complete " + projects + " project/s.";
            Console.WriteLine(arch);
        }
    }
}
