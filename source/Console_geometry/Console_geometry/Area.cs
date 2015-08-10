using System; 
using System.Runtime; //for basic math extensions
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Console_geometry
{
    public class Area
    {
        public Area()
        {
            
        }

        public decimal square(decimal side)
        {
            return side*side;
        }

        public decimal triangle(decimal side)
        {
            return 0;
        }
    }

    public class perimeter
    {
        public perimeter()
        {
            
        }

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

    
    public class Volume
    {
        public Volume()
        {
            
        }

        public decimal cube(decimal a)
        {
            double b = Math.Pow(Convert.ToDouble(a), 3); 
            
            return Convert.ToDecimal(b);
        }

        public decimal rectangularprism(decimal a, decimal b, decimal c)
        {
            return a*b*c;
        }

        public decimal cylinder(decimal b, decimal h)
        {
            return b*h;
        }
    }
}
