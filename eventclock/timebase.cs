using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventclock
{

    delegate void Handler();

    class TimeBase
    {
        public event Handler CountedMinute;
        public event Handler CountedHour;

        public void DoCount()
        {
            for (int i = 0; i < 86400; i++)
            {
                if (i % 60 == 0 && CountedMinute != null)
                {
                    CountedMinute();
                    
                }
                if (i % (60*60) == 0 && CountedHour != null)
                {
                    CountedHour();
                    Console.WriteLine("CountedHour()");
                }

            }
        }
    }
}
