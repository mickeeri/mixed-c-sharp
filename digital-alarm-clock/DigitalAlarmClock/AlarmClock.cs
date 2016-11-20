using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAlarmClock
{
    public class AlarmClock
    {
        // Fält 
        private int _alarmHour;
        private int _alarmMinute;
        private int _hour;
        private int _minute; 

        // Egenskaper 
        public int AlarmHour
        {
            get { return _alarmHour; }

            set
            {
                if (value < 0 || value > 23)
                { 
                    throw new ArgumentException(
                        "Alarmtimmen är inte i intervallet 0-23"); 
                }
                _alarmHour = value; 
            }
        }

        public int AlarmMinute
        {
            get { return _alarmMinute; }

            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException(
                        "Alarmminuten är inte i intervallet 0-59"); 
                }
                _alarmMinute = value; 
            }
        }

        public int Hour
        {
            get { return _hour; }

            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException(
                        "Timmen är inte i intervallet 0-23"); 
                }
                _hour = value; 
            }
        }

        public int Minute
        {
            get { return _minute; }

            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException(
                        "Minuten är inte i intervallet 0-59"); 
                }
                _minute = value;
            }
        }

        // Konstruktorer
        public AlarmClock() : this(default(int), default(int)) { }

        public AlarmClock(int hour, int minute) : this(hour, minute, default(int), default(int)) { }

        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        {
            Hour = hour;
            Minute = minute;
            AlarmHour = alarmHour;
            AlarmMinute = alarmMinute;
        }

        // Metoder
        // TickTock ökar minuten med 1 för varje anrop. Men om Minute är 59 tilldelas den 0 och timmen - så länge den inte är 23, då den också blir 0 - ökar med 1. 
        public bool TickTock()
        {
            if (Minute != 59) 
            {
                ++Minute;
            }
            else
            {
                Minute = 0;
                
                if (Hour != 23) 
                {
                    ++Hour; 
                }
                else 
                {
                    Hour = 0; 
                }
            }

            if (Hour == AlarmHour && Minute == _alarmMinute)
            {
                return true; 
            }
            return false;   
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0, 5}:{1:00} <{2}:{3:00}>", Hour, Minute, AlarmHour, AlarmMinute);

            return sb.ToString(); 
        }
    }
}
