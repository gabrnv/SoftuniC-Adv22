using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Engine_And_Tires
{
    internal class Tire
    {
        public int Year { get; set; }
        public double Preasure { get; set; }
        public Tire(int Year, double Preasure)
        {
            this.Year = Year;
            this.Preasure = Preasure;   
        }
    }
}
