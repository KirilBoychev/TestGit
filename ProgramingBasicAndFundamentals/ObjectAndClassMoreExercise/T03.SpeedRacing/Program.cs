using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            double travelDistance = 0;

            for (int i = 0; i < n; i++)
            {
                string[] inputCar = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string model = inputCar[0];
                double fuelAmount = double.Parse(inputCar[1]);
                double fuelConsumption = double.Parse(inputCar[2]);

                Car everyCar = new Car(model, fuelAmount, fuelConsumption, travelDistance);

                cars.Add(everyCar);
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandArr = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string model = commandArr[1];
                double kilometers = int.Parse(commandArr[2]);

                cars.Where(c => c.Model == model).ToList().ForEach(c => c.ImplementMethod(kilometers, model, cars));
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelDistance}");
            }
        }
    }

    class Car
    {
        public Car(string model, double fuelAmount, double fuelComsumption, double travelDistance)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelComsumptionPerKilometer = fuelComsumption;
            this.TravelDistance = travelDistance;
        }
        
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelComsumptionPerKilometer { get; set; }
        public double TravelDistance { get; set; }

        public void ImplementMethod(double kilometers, string model, List<Car> cars)
        {
            if (cars.Any(x => x.Model == model))
            {
                if (this.FuelComsumptionPerKilometer * kilometers <= this.FuelAmount)
                {
                    this.FuelAmount -= kilometers * this.FuelComsumptionPerKilometer;
                    this.TravelDistance += kilometers;
                }
                else
                {
                    Console.WriteLine($"Insufficient fuel for the drive");
                }
            }
        }
    }
}
