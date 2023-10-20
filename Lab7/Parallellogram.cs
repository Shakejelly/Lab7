using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public class Parallellogram : Geometry
    {
        public double l = 9.5;
        public double h = 18;

        public override double Area()
        {
            return l * h;
        }
    }
}
