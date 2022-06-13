using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                float tire1Pressure = float.Parse(input[5]);
                int tire1Age = int.Parse(input[6]);
                float tire2Pressure = float.Parse(input[7]);
                int tire2Age = int.Parse(input[8]);
                float tire3Pressure = float.Parse(input[9]);
                int tire3Age = int.Parse(input[10]);
                float tire4Pressure = float.Parse(input[11]);
                int tire4Age = int.Parse(input[12]);

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoType, cargoWeight);

                Tires[] tires = new Tires[4]
                {
                    new Tires(tire1Age, tire1Pressure),
                    new Tires(tire2Age, tire2Pressure),
                    new Tires(tire3Age, tire3Pressure),
                    new Tires(tire4Age, tire4Pressure),
                };

                
                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }

            string command = Console.ReadLine();

            var specialCars = new List<Car>();

            if (command == "fragile")
            {
                specialCars = cars
                    .Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(x => x.Pressure < 1))
                    .ToList();
            }
            else if (command == "flammable")
            {
                specialCars = cars.Where(x => x.Cargo.Type == "flammable"
                && x.Engine.Power > 250)
                    .ToList();
            }

            foreach (Car car in specialCars)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}
