using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> carsList = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var info = Console.ReadLine().Split();

                string model = info[0];
                double fuelAmount = double.Parse(info[1]);
                double fuelConsumptionFor1km = double.Parse(info[2]);
                Car car = new Car(model, fuelAmount, fuelConsumptionFor1km);
                carsList.Add(car);
            }

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                var cmdArgs = command.Split();

                string type = cmdArgs[0];
                string carModel = cmdArgs[1];
                int amountOfKm = int.Parse(cmdArgs[2]);

                Car car = carsList.Where(x => x.Model == carModel).First();

                car.Drive(amountOfKm);
            }

            foreach (Car car in carsList)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
