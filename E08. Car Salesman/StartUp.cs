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

            Engine[] engines = new Engine[n];

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                string model = input[0];
                int enginePower = int.Parse(input[1]);

                string efficiency = "";
                var displacement = 0;

                if (input.Length >= 3)
                {
                    if (int.TryParse(input[2], out displacement))
                    {
                        displacement = int.Parse(input[2]);
                    }
                    else
                    {
                        efficiency = input[2];
                    }
                }

                if (input.Length == 4)
                {
                    efficiency = input[3];
                }

                Engine engine = new Engine(model, enginePower, displacement, efficiency);

                engines[i] = engine;
            }

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];

                var engine = engines.First(x => x.Model == input[1]);

                int weight = 0;
                string color = "";

                if (input.Length >= 3)
                {
                    if (int.TryParse(input[2], out weight))
                    {
                        weight = int.Parse(input[2]);
                    }
                    else
                    {
                        color = input[2];
                    }
                }

                if (input.Length == 4)
                {
                    color = input[3];
                }

                Car car = new Car(model, engine, weight, color);
                cars.Add(car);
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model}:\n {car.Engine.Model}:\n   Power: {car.Engine.Power}");
                if (car.Engine.Displacement == 0)
                {
                    Console.WriteLine("   Displacement: n/a");
                }
                else
                {
                    Console.WriteLine($"   Displacement: {car.Engine.Displacement}");
                }

                if (car.Engine.Efficiency == "")
                {
                    Console.WriteLine("   Efficiency: n/a");
                }
                else
                {
                    Console.WriteLine($"   Efficiency: {car.Engine.Efficiency}");
                }

                if (car.Weight == 0)
                {
                    Console.WriteLine("  Weight: n/a");
                }
                else
                {
                    Console.WriteLine($"  Weight: {car.Weight}");
                }
                if (car.Color == "")
                {
                    Console.WriteLine("  Color: n/a");
                }
                else
                {
                    Console.WriteLine($"  Color: {car.Color}");
                }
            }
        }
    }
}
