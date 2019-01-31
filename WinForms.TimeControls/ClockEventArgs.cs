namespace System.Windows.Forms
{
    public class ClockEventArgs : System.EventArgs
    {
        public uint TimePoint { get; private set; }

        public ClockEventArgs(uint timePoint)
        {
            this.TimePoint = timePoint;
        }
    }
}
