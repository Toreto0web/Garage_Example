using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Creating objects manually without a Factory Pattern.
            Engine carEngine = new Engine(200);
            Tires carTires = new Tires("All-Season");
            Car car = new Car("XYZ123", "Toyota", "Camry", carEngine, carTires);

            Engine motorcycleEngine = new Engine(100);
            Tires motorcycleTires = new Tires("Sport");
            Motorcycle motorcycle = new Motorcycle("ABC987", "Yamaha", "R1", motorcycleEngine, motorcycleTires);

            Garage garage = new Garage(car, motorcycle);
            garage.StartVehicles();
        }
    }

}
