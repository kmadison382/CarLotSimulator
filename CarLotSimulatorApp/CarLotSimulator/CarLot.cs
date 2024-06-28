using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        public List<Car> Cars {get; set;}
        public CarLot()
        {
            Cars = new List<Car>();
        }
        public void AddCar(Car nextCar)
        {
            Cars.Add(nextCar);
        }

    }
}