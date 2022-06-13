using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParking
{
    public class Parking
    {
        public List<Car> Cars { get; set; }

        public int Capacity { get; set; }
        public Parking(int capacity)
        {
            this.Cars = new List<Car>();
            this.Capacity = capacity;
        }

        public int Count
        {
            get { return Cars.Count; }
        }


        public string AddCar(Car addedCar)
        {
            bool canAddAcr = true;

            foreach (var car in Cars)
            {
                if (car.RegistrationNumber == addedCar.RegistrationNumber)
                {
                    canAddAcr = false;
                    return "Car with that registration number, already exists!";

                }
            }
            if (Cars.Count + 1 > this.Capacity)
            {
                canAddAcr = false;
                return "Parking is full!";
            }
            if (canAddAcr)
            {
                Cars.Add(addedCar);
                return $"Successfully added new car {addedCar.Model} {addedCar.RegistrationNumber}";
            }
            return "";
        }

        public string RemoveCar(string registrationNumber)
        {
            bool isAvailable = false;

            foreach (var car in Cars)
            {
                if (car.RegistrationNumber == registrationNumber)
                {
                    isAvailable = true;
                }
            }
            
            if (isAvailable)
            {
                Car car = Cars.First(x => x.RegistrationNumber == registrationNumber);
                Cars.Remove(car);
                return $"Successfully removed {registrationNumber}";
            }
            else
            {
                return "Car with that registration number, doesn't exist!";
            }
        }

        public Car GetCar(string registrationNumber)
        {
           return Cars.First(x => x.RegistrationNumber == registrationNumber);
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (var registrationNumber in registrationNumbers)
            {
                if (Cars.Any(x => x.RegistrationNumber == registrationNumber))
                {
                    RemoveCar(registrationNumber);
                }
            }
        }
    }
}
