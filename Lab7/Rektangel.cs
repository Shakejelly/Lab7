using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Rektangel : Geometry
    {
        public double _sideA = 5;
        public double _sideB = 8;
        public override double Area()
        {
            return _sideA * _sideB;
        }
    }
}
