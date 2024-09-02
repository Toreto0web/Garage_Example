using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Example
{
    public class Tires
    {
        public string Type { get; set; }

        public Tires(string type)
        {
            Type = type;
        }

        public void Inflate()
        {
            Console.WriteLine($"{Type} tires inflated.");
        }
    }

}
