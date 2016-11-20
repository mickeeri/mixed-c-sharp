using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriskaFigurerA
{
    class Rectangle : Shape
    {
        public override double Area
        {
            get 
            {
                return Width * Lenght;
            }          
        }

        public override double Perimeter
        {
            get 
            {
                return 2 * Lenght + 2 * Width;
            }
        }
        
        public Rectangle(double length, double width)
            : base(length, width)
        {

        }
    }
}
