namespace System.Windows.Forms
{
    public partial class MinutesPicker : UserControl
    {
        public event EventHandler<ClockEventArgs> MinutesChanged;

        public event EventHandler<ClockEventArgs> MinutesHover;

        public event EventHandler Initialized;

        public MinutesPicker()
        {
            InitializeComponent();

            Initialize(0);
        }

        public void Initialize(uint minutes)
        {
            if (minutes >= 0 && minutes < 60)
            {
                this.clockControl.InitializeClock(0, 5);
                uint offset = minutes / 5;
                this.clockControl.SetTime(offset);
            }
            else
            {
                throw new Exception("invalid minute number");
            }
        }

        private void ClockControl_TimeChanged(object sender, ClockEventArgs e)
        {
            this.MinutesChanged?.Invoke(this, e);
        }

        private void ClockControl_ClockHover(object sender, ClockEventArgs e)
        {
            this.MinutesHover?.Invoke(this, e);
        }

        private void ClockControl_ClockInitialized(object sender, EventArgs e)
        {
            this.Initialized?.Invoke(this, e);
        }
    }
}
