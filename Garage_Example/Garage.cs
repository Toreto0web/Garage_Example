using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Example
{
    public class Garage
    {
        public Car GarageCar { get; set; }
        public Motorcycle GarageMotorcycle { get; set; }

        public Garage(Car car, Motorcycle motorcycle)
        {
            GarageCar = car;
            GarageMotorcycle = motorcycle;
        }

        public void StartVehicles()
        {
            GarageCar.StartCar();
            GarageMotorcycle.StartMotorcycle();
        }
    }

}
