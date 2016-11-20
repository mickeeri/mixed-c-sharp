using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Fraction
    {
        // Fält
        private int _numerator;
        private int _denominator;

        // Egenskaper
        public int Numerator // Täljare
        {
            get { return _numerator;  }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("OBS! Nämnaren får inte vara 0.");
                }
                
                _numerator = value;
            }
        }

        public int Denominator // Nämnare
        {
            get { return _denominator;  }
            set { _denominator = value;  }
        }
        
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator; 
        }
        
        public bool IsNegative()
        {
            if (Numerator < 0 || Denominator < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Fraction Add(Fraction secondFraction)
        {
            // Multiply the denominators with each other to get a common denominator. 
            int commonDenominator = Denominator * secondFraction.Denominator;            

            int resultNumerator = (Numerator * secondFraction.Denominator) + (secondFraction.Numerator * Denominator);

            // Finding the biggest common divider between the two integers. 
            int divider = Euklides(resultNumerator, commonDenominator); 

            // Simplifying the new fraction with the divider. 
            Fraction result = new Fraction((resultNumerator / divider), (commonDenominator / divider));

            return result; 
        }
        public Fraction Multiply(Fraction secondFraction)
        {
            // Method takes the second fraction-instance as an argument and compares with the first fraction. 
            int resultNumerator = secondFraction.Numerator * Numerator;
            int resultDenominator = secondFraction.Denominator * Denominator;
         
            int divider = Euklides(resultNumerator, resultDenominator);

            // Simplifying with acquired divider. 
            Fraction result = new Fraction((resultNumerator / divider), (resultDenominator / divider));

            return result; 
        }
        public bool IsEqualTo(Fraction secondFraction)
        {
            return (secondFraction.Denominator / secondFraction.Numerator == Denominator / Numerator);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0}/{1}", Numerator, Denominator);

            return sb.ToString(); 
        }

        public int Euklides(int numerator, int denominator)
        { 
            int largestNumber;
            int smallestNumber;
            int remainder = 0;

            if (numerator > denominator)
            {
                largestNumber = numerator;
                smallestNumber = denominator;
            }
            else
            {
                largestNumber = denominator;
                smallestNumber = numerator; 
            }
            
            while (smallestNumber != 0)
            {
                remainder = largestNumber % smallestNumber;
                largestNumber = smallestNumber;
                smallestNumber = remainder;
            }

            return largestNumber; 
        }
    }
}