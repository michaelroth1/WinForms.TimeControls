using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timePicker1.SetTime("01:35");
        }

        private void clockControl1_ClockInitialized(object sender, EventArgs e)
        {
            this.clockControl1.SetTime(5);
        }

        private void TimePicker1_TimeChanged(object sender, TimePickerEventArgs e)
        {
            MessageBox.Show(e.FormattedTime);
        }
    }
}
