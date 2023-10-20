using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public class Fyrkant : Geometry
    {
        public double _side = 4.5;
         
        public override double Area()
        {
            return _side * _side;
        }
    }
}
