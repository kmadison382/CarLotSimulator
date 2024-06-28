using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            CarLot carLot = new CarLot();

            var oldCar = new Car();
            oldCar.Make = "Ford";
            oldCar.Model = "Model T";
            oldCar.Year = 1915;
            oldCar.EngineNoise = "click click";
            oldCar.HonkNoise = "beep beep";
            oldCar.IsDriveable = false;

            carLot.AddCar(oldCar);

            var newCar = new Car(2020, "Chevy", "Tahoe", "vroom!", "beeeeee!", true);
            carLot.AddCar(newCar);

            var futureCar = new Car()
            {
                Year = 2100,
                Make = "Astro",
                Model = "Spectra",
                EngineNoise = "whirr-purr",
                HonkNoise = "dwoo-ding!",
                IsDriveable = true,
            };
            carLot.AddCar(futureCar);

            foreach (Car car in carLot.Cars)
            {
                Console.WriteLine($"Here is a vehicle made in {car.Year} by {car.Make}, called the {car.Model}.");
            }

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
