using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Garage_Example
{
    public class Motorcycle : Vehicle
    {
        public Engine MotorcycleEngine { get; set; }
        public Tires MotorcycleTires { get; set; }

        public Motorcycle(string licensePlate, string make, string model, Engine engine, Tires tires)
            : base(licensePlate, make, model)
        {
            MotorcycleEngine = engine;
            MotorcycleTires = tires;
        }

        public void StartMotorcycle()
        {
            MotorcycleEngine.Start();
            Console.WriteLine("Motorcycle started.");
        }
    }

}
