using System;

namespace aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int wide = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double volume = lenght * wide * hight * 0.001;
            double water = volume * (1 - percent / 100);
            Console.WriteLine(water);
        }
    }
}
