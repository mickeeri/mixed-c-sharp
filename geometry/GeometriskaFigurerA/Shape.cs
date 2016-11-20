using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriskaFigurerA
{
    enum ShapeType { Ellispe, Rectangle }; 
    abstract class Shape
    {
        // Fält 
        private double _length;
        private double _width;

        // Egenskaper
        public abstract double Area
        {
            get; 
        }

        public double Lenght
        {
            get { return _length; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(); 
                }
                _length = value; 
            }
        }
        public abstract double Perimeter
        {
            get;
        }

        public double Width
        {
            get { return _width; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException(); 
                }                
                _width = value; 
            }
        }

        protected Shape(double length, double width)
        {
            Lenght = length;
            Width = width; 
        }

        // Metod

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("\nLängd  : {0, 10:F1}", Lenght);
            sb.AppendFormat("\nHöjd   : {0, 10:F1}", Width);
            sb.AppendFormat("\nOmkrets: {0, 10:F1}", Perimeter);
            sb.AppendFormat("\nArea   : {0, 10:F1}", Area);            

            return sb.ToString(); 
        }   
    }
}
