using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public int Year {get; set;}
        public string Make {get; set;}
        public string Model {get; set;}
        public string EngineNoise {get; set;}
        public string HonkNoise {get; set;}
        public bool IsDriveable {get; set;}

        public void MakeEngineNoise()
        {
            Console.WriteLine($"'{EngineNoise}'");
        }
        public void MakeHonkNoise()
        {
            Console.WriteLine($"'{HonkNoise}'");
        }
        public Car() 
        { 
            CarLot.AddCar(this);
        }
        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
            CarLot.AddCar(this);
        }
    }
}