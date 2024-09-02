using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Example
{
    public class Vehicle
    {
        public string LicensePlate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public Vehicle(string licensePlate, string make, string model)
        {
            LicensePlate = licensePlate;
            Make = make;
            Model = model;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Vehicle: {Make} {Model}, License Plate: {LicensePlate}");
        }
    }

}
