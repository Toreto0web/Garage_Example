using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Example
{
    public class Engine
    {
        public int HorsePower { get; set; }

        public Engine(int horsePower)
        {
            HorsePower = horsePower;
        }

        public void Start()
        {
            Console.WriteLine($"Engine with {HorsePower} HP started.");
        }
    }

}
