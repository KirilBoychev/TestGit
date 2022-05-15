using System;

namespace T01.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            //В една кинозала столовете са наредени в правоъгълна форма в r реда и c колони.
            //Има три вида прожекции с билети на различни цени:
            //•	Premiere – премиерна прожекция, на цена 12.00 лева.
            //•	Normal – стандартна прожекция, на цена 7.50 лева.
            //•	Discount – прожекция за деца, ученици и студенти на намалена цена от 5.00 лева.
            //Напишете програма, която чете тип прожекция(стринг), брой редове и брой колони в залата(цели числа), въведени от потребителя,
            //и изчислява общите приходи от билети при пълна зала.Резултатът да се отпечата във формат като в примерите по-долу,
            //с 2 знака след десетичната точка.  
            const double premiere = 12.0;
            const double normal = 7.5;
            const double discount = 5.0;
            
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            switch (projection)
            {
                case "Premiere":
                    double result = premiere * rows * columns;
                    Console.WriteLine($"{result:f2} leva");
                    break;
                case "Normal":
                    double result2 = normal * rows * columns;
                    Console.WriteLine($"{result2:f2} leva");
                    break;
                case "Discount":
                    double result3 = discount * rows * columns;
                    Console.WriteLine($"{result3:f2} leva");
                    break;
                default:
                    break;
            }
        }
    }
}
