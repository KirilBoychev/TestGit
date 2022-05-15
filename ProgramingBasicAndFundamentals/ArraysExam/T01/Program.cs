using System;

namespace T01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfVagons = int.Parse(Console.ReadLine());

            int[] arr = new int[numberOfVagons];
            int sum = 0;
            for (int everyVagon = 0; everyVagon < numberOfVagons; everyVagon++)
            {
                int peopleInVagon = int.Parse(Console.ReadLine());
                arr[everyVagon] = peopleInVagon;
                sum += peopleInVagon;
            }
            Console.WriteLine(String.Join(' ', arr));
            Console.WriteLine(sum);
        }
    }
}
