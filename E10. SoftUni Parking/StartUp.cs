using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var car = new Car("Skoda", "Fabia", 65, "CC1856BG");
            var car2 = new Car("Audi", "A3", 110, "EB8787MN");
            var car3 = new Car("BMW", "A3", 110, "Tes88");
            var car4 = new Car("VW", "A3", 110, "T12333");
            var car5 = new Car("MErcdes", "A3", 110, "YU87777");
            var car6 = new Car("tests", "A3", 110, "test");
            var car7 = new Car("ггггdгг", "A3", 110, "гггг7gг");




            Console.WriteLine(car.ToString());
            // Make: Skoda
            // Model: Fabia
            // HorsePower: 65
            // RegistrationNumber: CC1856BG


            var parking = new Parking(5);
            Console.WriteLine(parking.AddCar(car));
            // Successfully added new car Skoda CC1856BG

            Console.WriteLine(parking.AddCar(car));
            // Car with that registration number, already exists!

            Console.WriteLine(parking.AddCar(car2));
            // Successfully added new car Audi EB8787MN
            Console.WriteLine(parking.AddCar(car3));
            Console.WriteLine(parking.AddCar(car4));

            Console.WriteLine(parking.GetCar("EB8787MN").ToString());
            // Make: Audi
            // Model: A3
            // HorsePower: 110
            // RegistrationNumber: EB8787MN
            Console.WriteLine(parking.AddCar(car5));
            Console.WriteLine(parking.AddCar(car6));

            List<string> registrationNums = new List<string>()
            {
                "CC1856BG",
                "EB8787dd",
                "Tes88"
            };

            Console.WriteLine(parking.AddCar(car7));


            List<string> registrationNums1 = parking.Cars.Select(x => x.RegistrationNumber).ToList();

            Console.WriteLine(parking.RemoveCar("T12333"));
            // Successfullyremoved EB8787MN
            Console.WriteLine(parking.AddCar(car6));
            Console.WriteLine(parking.AddCar(car6));

            parking.RemoveSetOfRegistrationNumber(registrationNums);

            Console.WriteLine(parking.Count);
            // 1
        }
    }
}
