using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public class Ellips : Geometry
    {

        public double a = 2;
        public double b = 5;


        public override double Area()
        {
           return Math.PI * a * b;
        }
    }
}
