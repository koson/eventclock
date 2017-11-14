using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventclock
{
    class ClockDisplay
    {
        public int minuteCount { get; private set; }
        public int hourCount { get; private set; }
        public ClockDisplay(TimeBase timebase)
        {
            minuteCount = 0;
            hourCount = 0;
            timebase.CountedMinute += Timebase_CountMinute;
            timebase.CountedHour += Timebase_CountedHour;
        }

        private void Timebase_CountedHour()
        {
            hourCount++;
        }

        private void Timebase_CountMinute()
        {
            minuteCount ++;
        }
    }
}
