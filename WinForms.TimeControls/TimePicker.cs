using System.Drawing;

namespace System.Windows.Forms
{
    public partial class TimePicker : UserControl
    {
        public event EventHandler<TimePickerEventArgs> TimeChanged;

        public TimePicker()
        {
            InitializeComponent();
        }

        public void SetTime(string formattedTime)
        {
            uint hours = uint.Parse(formattedTime.Split(':')[0]);
            uint minutes = uint.Parse(formattedTime.Split(':')[1]);
            this.SetTime(hours, minutes);
        }

        public void SetTime(uint hours, uint minutes)
        {
            this.hoursLabel.Text = hours.ToString("D2");
            this.minutesLabel.Text = minutes.ToString("D2");
        }

        private void LabelMinutes_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var point = this.PointToScreen(new Point(0, 0));

                point = Point.Add(point, new Size(this.minutesLabel.Location));

                point = Point.Add(point, new Size(0, this.minutesLabel.Height));

                var minutesControl = new MinutesPicker();

                minutesControl.MinutesChanged += new System.EventHandler<ClockEventArgs>(this.Minutes_Changed);

                minutesControl.MinutesHover += new System.EventHandler<ClockEventArgs>(this.Minutes_Hover);

                minutesControl.Initialized += new System.EventHandler(this.Minutes_Initialized);

                this.contextMenue.Show(point, minutesControl);
            }
        }

        private void Minutes_Initialized(object sender, EventArgs e)
        {
            MinutesPicker minutesControl = (MinutesPicker)sender;

            uint minutes = uint.Parse(this.minutesLabel.Text);

            minutesControl.Initialize(minutes);
        }

        private void LabelHour_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var point = this.PointToScreen(new Point(0, 0));

                point = Point.Add(point, new Size(this.hoursLabel.Location));

                point = Point.Add(point, new Size(7, this.hoursLabel.Height));

                var hourControl = new HourPicker();

                hourControl.HourChanged += new System.EventHandler<ClockEventArgs>(this.Hours_Changed);

                hourControl.HourHover += new System.EventHandler<ClockEventArgs>(this.Hours_Hover);

                hourControl.Initialized += new System.EventHandler(this.Hour_Initialized);

                this.contextMenue.Show(point, hourControl);
            }
        }

        private void Hour_Initialized(object sender, EventArgs e)
        {
            HourPicker hourControl = (HourPicker)sender;

            uint hours = uint.Parse(this.hoursLabel.Text);

            hourControl.Initialize(hours);
        }

        private void Hours_Hover(object sender, ClockEventArgs e)
        {
            this.hoursLabel.Text = e.TimePoint.ToString("D2");
        }

        private void Hours_Changed(object sender, ClockEventArgs e)
        {
            this.Hours_Hover(this, e);
            this.contextMenue.Hide();
            this.InvokeTimeChangedEvent();
        }

        private void Minutes_Hover(object sender, ClockEventArgs e)
        {
            this.minutesLabel.Text = e.TimePoint.ToString("D2");
        }

        private void Minutes_Changed(object sender, ClockEventArgs e)
        {
            this.Minutes_Hover(this, e);
            this.contextMenue.Hide();
            this.InvokeTimeChangedEvent();
        }

        private void InvokeTimeChangedEvent()
        {

            string formattedTime = $"{this.hoursLabel.Text}:{this.minutesLabel.Text}";
            uint hours = uint.Parse(this.hoursLabel.Text);
            uint minutes = uint.Parse(this.minutesLabel.Text);
            this.TimeChanged?.Invoke(this, new TimePickerEventArgs(hours, minutes, formattedTime));
        }
    }
}
