using System;

namespace T07.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            const double studioMayOktober = 50;
            const double apartmentMayOktober = 65;
            const double studioJuneSeptember = 75.20;
            const double apartmentJuneSeptember = 68.70;
            const double studioJulyAugust = 76;
            const double apartmentJulyAugust = 77;

            string mouth = Console.ReadLine();
            int countOfNights = int.Parse(Console.ReadLine());

            double expensesStudio = 0;
            double expensesApartment = 0;

            switch (mouth)
            {
                case "May":
                case "October":
                    expensesStudio = studioMayOktober * countOfNights;
                    expensesApartment = apartmentMayOktober * countOfNights;
                    if (countOfNights > 7 && countOfNights <= 14)
                    {
                        expensesStudio -= expensesStudio * 0.05;
                    }
                    else if (countOfNights > 14)
                    {
                        expensesStudio -= expensesStudio * 0.30;
                    }
                        break;
                case "June":
                case "September":
                    expensesStudio = studioJuneSeptember * countOfNights;
                    expensesApartment = apartmentJuneSeptember * countOfNights;
                    if (countOfNights > 14)
                    {
                        expensesStudio -= expensesStudio * 0.20;
                    }
                    break;
                case "July":
                case "August":
                    expensesStudio = studioJulyAugust * countOfNights;
                    expensesApartment = apartmentJulyAugust * countOfNights;
                    break;
            }

         
            if (countOfNights > 14)
            {
                expensesApartment -= expensesApartment * 0.10;
            }

            Console.WriteLine($"Apartment: {expensesApartment:f2} lv.");
            Console.WriteLine($"Studio: {expensesStudio:f2} lv.");


        }
    }
}
