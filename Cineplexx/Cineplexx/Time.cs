using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cineplexx
{
    public class Time
    {
        private int hours;
        private int minutes;

        private Time movieTime;

        public int Hours
        {
            get { return this.hours; }
            set
            {
                if (value >= 2 && value <= 4)
                    hours = value;
                else
                    throw new ArgumentOutOfRangeException("Hours must be between 2 and 4.");
            }
        }

        public int Minutes
        {
            get { return this.minutes; }
            set
            {
                if (value >= 0 && value < 60)
                    minutes = value;
                else
                    throw new ArgumentOutOfRangeException("Minutes must be between 0 and 59.");
            }
        }
        public Time()
        {
            
        }

        public Time(int hours, int minutes)
        {
            Hours = hours;
            Minutes = minutes;
        }

        public Time MovieTime
        {
            get { return this.movieTime; }
            set { this.movieTime = value; }
        }


        public override string ToString() => $"{hours}h {minutes}m";
    }
}
        
        