using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAlarmClockB
{
    class ClockDisplay
    {
        private NumberDisplay _hourDisplay = new NumberDisplay(23); // Max 23 om det är timmar. 
        private NumberDisplay _minuteDisplay = new NumberDisplay(59); // Max 59 om det är minuter. 

        public int Hour
        {
            get { return _hourDisplay.Number; }
            set { value = _hourDisplay.Number; }
        }

        public int Minute
        {
            get { return _minuteDisplay.Number; }
            set { value = _minuteDisplay.Number; }
        }

        // Konstruktorer
        public ClockDisplay()
            : this(default(int), default(int))
        {

        }

        public ClockDisplay(int hour, int minute)
        {
            Hour = hour;
            Minute = minute;
        }

        // Metoder
        public void Increment() // Metod anropas för att få ClockDisplay-objekt att gå en minut. Då värdet för minuterna blir 0 ökas värdet för timme med 1. 
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
