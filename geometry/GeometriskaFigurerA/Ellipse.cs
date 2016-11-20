using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriskaFigurerA
{
    class Ellipse : Shape
    {        
        public override double Area
        {
            get
            {
                return Math.PI * (Lenght / 2) * (Width / 2); 
            }
        }

        public override double Perimeter
        {
            get
            {
                double a = Lenght / 2; 
                double b = Width / 2;

                return Math.PI * Math.Sqrt(2 * a * a + 2 * b * b);
            }
        }

        public Ellipse(double lenght, double width)
            : base(lenght, width)
        {

        }

    }

}
