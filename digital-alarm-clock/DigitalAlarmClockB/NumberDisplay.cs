using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAlarmClockB
{
    class NumberDisplay
    {
        private int _maxNumber;
        private int _number;

        // Egenskaper 
        public int MaxNumber
        {
            get { return _maxNumber; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _maxNumber = value;
            }
        }

        public int Number
        {
            get { return _number; }
            set
            {
                if (value < 0 && value > MaxNumber)
                {
                    throw new ArgumentException();
                }
                _number = value;
            }
        }

        // Konstruktorer
        public NumberDisplay(int maxNumber)
            : this(maxNumber, default(int))
        {

        }

        public NumberDisplay(int maxNumber, int number)
        {
            MaxNumber = maxNumber;
            Number = number;
        }

        //Metoder
        public void Increment() // Metod som får numberDisplay-objektet att öka med 1. Då _maxnumber har passerats ska _number tilldelas värdet 0.
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override string ToString(string format)
        {
            return base.ToString();
        }
    }
}
