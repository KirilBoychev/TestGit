using System;

namespace basketball
{
    class Program
    {
        static void Main(string[] args)
        {
            int taxForOneYear = int.Parse(Console.ReadLine());
            double traniner = taxForOneYear * 0.6;
            double equipment = traniner * 0.8;
            double ball = equipment * 0.25;
            double accesoaries = 0.2 * ball;
            double expenses = taxForOneYear + traniner + equipment + accesoaries + ball;
            Console.WriteLine(expenses);
        }
    }
}
