using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        private static int numberOfCars;
        private static List<Car> Cars {get; set;}
        public CarLot()
        {
            Cars = new List<Car>();      
        }
        public static void AddCar(Car nextCar)
        {
            Cars.Add(nextCar);
            numberOfCars++;
        }
        public static void GetNumberOfCars()
        {
            Console.WriteLine(numberOfCars);
        }
        public static void ShowOffCars()
        {
            foreach (Car car in CarLot.Cars)
            {
                Console.Write($"Here is a vehicle made in {car.Year} by {car.Make}, called the {car.Model}. ");
                car.MakeHonkNoise();
            }
        }

    }
}