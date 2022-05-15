using System;
using System.Collections.Generic;
using System.Linq;

namespace T03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split('|', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string carName = input[0];
                int mileage = int.Parse(input[1]);
                int fuelAvailable = int.Parse(input[2]);

                Car currOne = new Car(carName, mileage, fuelAvailable);

                cars.Add(currOne);
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] commandArr = command
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string com = commandArr[0];
                string carName = commandArr[1];

                if (com == "Drive")
                {
                    int distance = int.Parse(commandArr[2]);
                    int fuel = int.Parse(commandArr[3]);
                    foreach (var car in cars.Where(x => x.CarName == carName))
                    {
                        if (fuel > car.FuelAvailable)
                        {
                            Console.WriteLine($"Not enough fuel to make that ride");
                        }
                        else
                        {
                            car.Mileage += distance;
                            car.FuelAvailable -= fuel;
                            if (car.Mileage >= 100000)
                            {
                                cars.Remove(car);
                                Console.WriteLine($"Time to sell the {car.CarName}!");
                            }
                            else
                            {
                                Console.WriteLine($"{car.CarName} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                            }
                        }
                    }
                }
                else if (com == "Refuel")
                {
                    int fuel = int.Parse(commandArr[2]);
                    foreach (var car in cars.Where(x => x.CarName == carName))
                    {
                        if (car.FuelAvailable + fuel > 75)
                        {
                            fuel = 75 - car.FuelAvailable;
                            car.FuelAvailable = 75;
                        }
                        else
                        {
                            car.FuelAvailable += fuel;
                        }
                        Console.WriteLine($"{car.CarName} refueled with {fuel} liters");
                    }
                }
                else if (com == "Revert")
                {
                    int kilometers = int.Parse(commandArr[2]);
                    foreach (var car in cars.Where(x => x.CarName == carName))
                    {
                        if (car.Mileage + kilometers > 10000)
                        {
                            kilometers = 10000 - car.Mileage;
                            car.Mileage = 10000;
                        }
                        else
                        {
                            car.Mileage += kilometers;
                            
                        }
                        Console.WriteLine($"{car.CarName} mileage decreased by {kilometers} kilometers");
                    }
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.CarName} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.FuelAvailable} lt.");
            }
        }
    }

    class Car
    {
        public Car(string carName, int mileage, int fuelAvailable)
        {
            this.CarName = carName;
            this.Mileage = mileage;
            this.FuelAvailable = fuelAvailable;
        }
        public string CarName { get; set; }
        public int Mileage { get; set; }
        public int FuelAvailable { get; set; }
    }
}
