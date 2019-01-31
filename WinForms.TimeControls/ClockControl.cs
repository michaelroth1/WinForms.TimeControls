using System.Drawing;

namespace System.Windows.Forms
{
    public partial class ClockControl : UserControl
    {
        private int _initialCount = 0;

        public event EventHandler<ClockEventArgs> TimeChanged;

        public event EventHandler<ClockEventArgs> ClockHover;

        public event EventHandler<EventArgs> ClockInitialized;

        public ClockControl()
        {
            InitializeComponent();

            SetTime();
        }

        /// <summary>
        ///  Sets the control to twelve o'clock
        /// </summary>
        public void SetTime()
        {
            this.SetTime(0);
        }

        /// <summary>
        /// Sets the 'given' point as actual time
        /// </summary>
        /// <param name="point">number 'clockpoint'</param>
        public void SetTime(uint point)
        {
            ClearClock();

            ClockPoint clockPoint = GetClockPointByNumber(point);

            DrawLine(clockPoint);
        }

        /// <summary>
        /// Initializes the clock control with the numbers from 0 - 11
        /// </summary>
        public void InitializeClock()
        {
            this.InitializeClock(0, 1);
        }

        /// <summary>
        /// Initializes the clock numbers 
        /// </summary>
        /// <param name="start">number of the twelve o'clock position</param>
        /// <param name="steps">stepwidth between two clock numbers</param>
        public void InitializeClock(uint start, uint steps)
        {
            foreach (ClockPoint clockPoint in this.Controls)
            {
                var number = GetNumberOfClockPoint(clockPoint) * steps + start;
                clockPoint.LabelText = number.ToString();
            }
        }

        /// <summary>
        /// Clears the blue color in all clockpoints
        /// </summary>
        private void ClearClock()
        {
            foreach (ClockPoint clockPoint in this.Controls)
            {
                clockPoint.BackgroundImage = null;
            }
        }

        /// <summary>
        /// Returns the 'clockpoint' by the given 'number'
        /// </summary>
        private ClockPoint GetClockPointByNumber(uint number)
        {
            foreach (ClockPoint clockPoint in this.Controls)
            {
                if (this.GetNumberOfClockPoint(clockPoint) == number)
                {
                    return clockPoint;
                }
            }
            return null;
        }

        /// <summary>
        /// Returns the number of the given 'clockpoint'
        /// </summary>
        private int GetNumberOfClockPoint(ClockPoint clockPoint)
        {
            string name = clockPoint.Name;

            var number = name.Replace("clockPoint", "");

            return System.Convert.ToInt32(number);
        }

        /// <summary>
        /// Draw the line between the centerpoint of the control and the given 'clockpoint'
        /// </summary>
        private void DrawLine(ClockPoint clockPoint)
        {
            Pen pen = new Pen(Color.DodgerBlue);
            var graphics = this.CreateGraphics();
            graphics.Clear(BackColor);

            var endPoint = new Point(clockPoint.Location.X + 10, clockPoint.Location.Y + 10);

            graphics.DrawLine(pen, 75, 77, endPoint.X, endPoint.Y);

            clockPoint.BackgroundImage = TimeControls.Properties.Resources.icons8_filled_circle_60;
        }

        /// <summary>
        /// Initialize the Clock after drawing (wait for completely painting the Control with the blue line)
        /// </summary>
        /// <remarks>the number 3 is figured out by trying and error</remarks>
        private void ClockControl_Paint(object sender, PaintEventArgs e)
        {
            if (_initialCount < 3)
            {
                _initialCount++;
                this.SetTime();
            }
            else if (_initialCount == 3)
            {
                _initialCount++;
                this.ClockInitialized?.Invoke(this, EventArgs.Empty);
            }
        }

        private void Point_Click(object sender, EventArgs e)
        {
            ClockPoint clockPoint = (ClockPoint)sender;
            var args = new ClockEventArgs(uint.Parse(clockPoint.LabelText));
            this.TimeChanged?.Invoke(this, args);
        }

        private void Point_MouseEnter(object sender, EventArgs e)
        {
            var clockPoint = (ClockPoint)sender;
            this.ClearClock();
            this.DrawLine(clockPoint);

            var args = new ClockEventArgs(uint.Parse(clockPoint.LabelText));
            this.ClockHover?.Invoke(this, args);
        }
    }
}
