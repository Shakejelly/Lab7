using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public class Circle : Geometry
    {

        public double Radius = 7.3;
        
        public override double Area()
        {

            return Radius * Radius * Math.PI;


        }

    }
}
