using System;
using System.Windows.Forms;

namespace System.Windows.Forms
{
    public partial class HourPicker : UserControl
    {
        public event EventHandler<ClockEventArgs> HourChanged;

        public event EventHandler<ClockEventArgs> HourHover;

        public event EventHandler Initialized;

        public HourPicker()
        {
            InitializeComponent();

            Initialize(0);
        }

        private void AMButton_Click(object sender, EventArgs e)
        {
            this.clockControl.InitializeClock(0, 1);
        }

        private void PMButton_Click(object sender, EventArgs e)
        {
            this.clockControl.InitializeClock(12, 1);
        }

        public void Initialize(uint hours)
        {
            if (hours >= 0 && hours < 12)
            {
                this.clockControl.InitializeClock(0, 1);
                this.clockControl.SetTime(hours);
            }
            else if (hours >= 12 && hours < 24)
            {
                this.clockControl.InitializeClock(12, 1);
                this.clockControl.SetTime(hours - 12);
            }
            else
            {
                throw new Exception("invalid hour number");
            }
        }

        private void ClockControl_TimeChanged(object sender, ClockEventArgs e)
        {
            this.HourChanged?.Invoke(this, e);
        }

        private void ClockControl_ClockHover(object sender, ClockEventArgs e)
        {
            this.HourHover?.Invoke(this, e);
        }

        private void ClockControl_Initialized(object sender, EventArgs e)
        {
            this.Initialized?.Invoke(this, e);
        }
    }
}
