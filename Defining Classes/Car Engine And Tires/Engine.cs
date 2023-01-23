using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Engine_And_Tires
{
    internal class Engine
    {
        public int HorsePower { get; set; }
        public double CubicCapacity { get; set; }

        public Engine(int HorsePower, double CubicCapacity)
        {
            this.HorsePower = HorsePower;
            this.CubicCapacity = CubicCapacity;
        }
    }
}
