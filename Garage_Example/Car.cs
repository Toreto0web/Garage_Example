using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Garage_Example
{
    public class Car : Vehicle
    {
        public Engine CarEngine { get; set; }
        public Tires CarTires { get; set; }

        public Car(string licensePlate, string make, string model, Engine engine, Tires tires)
            : base(licensePlate, make, model)
        {
            CarEngine = engine;
            CarTires = tires;
        }

        public void StartCar()
        {
            CarEngine.Start();
            Console.WriteLine("Car started.");
        }
    }

}
