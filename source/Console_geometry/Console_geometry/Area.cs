using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_geometry
{
    class Area
    {
        public decimal square(decimal side)
        {
            return side*side;
        }

        public decimal triangle(decimal side)
        {
            return 0;
        }
    }

    class perimeter
    {
        public decimal square(decimal side)
        {
            return side*4;
        }

        public decimal rectangle(decimal length, decimal width)
        {
            return (2*length) + (2*width);
        }

        public decimal triangle(decimal a, decimal b, decimal c)
        {
            return a + b + c;
        }

        public decimal quadrilateral(decimal a, decimal b, decimal c, decimal d)
        {
            return a + b + c + d;
        }

        public double circle(double radius)
        {
            return 2*Math.PI*radius;
        }
    }
}
