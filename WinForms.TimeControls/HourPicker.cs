namespace System.Windows.Forms
{
    public partial class HourPicker : UserControl
    {
        public event EventHandler<ClockEventArgs> HourChanged;

        public event EventHandler<ClockEventArgs> HourHover;

        public HourPicker()
        {
            InitializeComponent();

            Initialize(0);
        }

        private void AMButton_Click(object sender, EventArgs e)
        {
            this.clockControl.InitializeClock(0, 1);

            var args = new ClockEventArgs(this.clockControl.GetTime());
            this.HourHover?.Invoke(this, args);
        }

        private void PMButton_Click(object sender, EventArgs e)
        {
            this.clockControl.InitializeClock(12, 1);

            var args = new ClockEventArgs(this.clockControl.GetTime() + 12);
            this.HourHover?.Invoke(this, args);
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
    }
}
