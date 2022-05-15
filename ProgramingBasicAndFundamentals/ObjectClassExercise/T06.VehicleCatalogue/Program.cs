using System;
using System.Collections.Generic;
using System.Linq;

namespace T06.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;

            List<Vehicle> listOfCars = new List<Vehicle>();
            List<Vehicle> listOfTrucks = new List<Vehicle>();
            List<string> vehicleObject = new List<string>();

            while ((command = Console.ReadLine()) != "End")
            {
                vehicleObject = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string type = vehicleObject[0];
                string model = vehicleObject[1];
                string color = vehicleObject[2];
                int power = int.Parse(vehicleObject[3]);

                Vehicle currentVehicle = new Vehicle(type, model, color, power);

                if (type == "car")
                {
                    if (!listOfCars.Any(x => x.ModelOfVehicle.Contains(model)))
                    {
                        listOfCars.Add(currentVehicle);
                    }
                }
                else if (type == "truck")
                {
                    if(!listOfTrucks.Any(x => x.ModelOfVehicle.Contains(model)))
                    {
                        listOfTrucks.Add(currentVehicle);
                    }
                }

                int vehiclesCount = listOfCars.Count + listOfTrucks.Count;
                if (vehiclesCount > 50)
                {
                    break;
                }
            }


            string model1;

            while ((model1 = Console.ReadLine()) != "Close the Catalogue")
            {
                string type1 = String.Empty;
                string color1 = String.Empty;
                int power1 = 0;
                if (listOfCars.Any(m => m.ModelOfVehicle.Contains(model1)))
                {
                    foreach (var car in listOfCars.Where(m => m.ModelOfVehicle.Contains(model1)))
                    {
                        type1 = car.TypeOfVehicle;
                        model1 = car.ModelOfVehicle;
                        color1 = car.ColorOfVehicle;
                        power1 = car.HorsepowerOfVehicle;
                    }
                    Console.WriteLine($"Type: {"Car"}");
                    Console.WriteLine($"Model: {model1}");
                    Console.WriteLine($"Color: {color1}");
                    Console.WriteLine($"Horsepower: {power1}");
                }
                else if (listOfTrucks.Any(m => m.ModelOfVehicle.Contains(model1)))
                {
                    foreach (var truck in listOfTrucks.Where(m => m.ModelOfVehicle.Contains(model1)))
                    {
                        type1 = truck.TypeOfVehicle;
                        model1 = truck.ModelOfVehicle;
                        color1 = truck.ColorOfVehicle;
                        power1 = truck.HorsepowerOfVehicle;
                    }
                    Console.WriteLine($"Type: {"Truck"}");
                    Console.WriteLine($"Model: {model1}");
                    Console.WriteLine($"Color: {color1}");
                    Console.WriteLine($"Horsepower: {power1}");
                }
            }

            if (model1 == "Close the Catalogue")
            {
                double sum = 0;
                foreach (var car in listOfCars)
                {
                    sum += (double)car.HorsepowerOfVehicle;
                }
                sum /= (double)listOfCars.Count;

                double sum1 = 0;
                foreach (var truck in listOfTrucks)
                {
                    sum1 += (double)truck.HorsepowerOfVehicle;
                }
                sum1 /= (double)listOfTrucks.Count;

                if (sum > 0 && sum1 > 0)
                {
                    Console.WriteLine($"{"Cars"} have average horsepower of: {sum:f2}.");
                    Console.WriteLine($"{"Trucks"} have average horsepower of: {sum1:f2}.");
                }
                else if (sum == 0 && sum1 > 0)
                {
                    Console.WriteLine($"{"Trucks"} have average horsepower of: {sum1:f2}.");
                }
                else if (sum > 0 && sum1 == 0)
                {
                    Console.WriteLine($"{"Cars"} have average horsepower of: {sum:f2}.");
                }
            }
        }
    }
    class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsepower)
        {
            this.TypeOfVehicle = type;
            this.ModelOfVehicle = model;
            this.ColorOfVehicle = color;
            this.HorsepowerOfVehicle = horsepower;
        }
        public string TypeOfVehicle { get; set; }
        public string ModelOfVehicle { get; set; }
        public string ColorOfVehicle { get; set; }
        public int HorsepowerOfVehicle { get; set; }
    }
}
