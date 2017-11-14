using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eventclock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeBase timebase = new TimeBase();
            ClockDisplay clockDisplay = new ClockDisplay(timebase);
            timebase.DoCount();
            MessageBox.Show("Minutes = " 
                + clockDisplay.minuteCount.ToString()
                + ", Hours = " + clockDisplay.hourCount.ToString());
        }
    }
}
