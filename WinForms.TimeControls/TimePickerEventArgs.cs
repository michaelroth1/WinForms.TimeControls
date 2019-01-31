namespace System.Windows.Forms
{
    public class TimePickerEventArgs : System.EventArgs
    {
        public uint Hours { get; private set; }

        public uint Minutes { get; private set; }

        public string FormattedTime { get; private set; }

        public TimePickerEventArgs(uint hours, uint minutes, string formattedTime)
        {
            this.Hours = hours;
            this.Minutes = minutes;
            this.FormattedTime = formattedTime;
        }
    }
}
