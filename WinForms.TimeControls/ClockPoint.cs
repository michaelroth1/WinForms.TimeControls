namespace System.Windows.Forms
{
    public partial class ClockPoint : UserControl
    {
        public new event EventHandler MouseEnter;

        public new event EventHandler MouseLeave;

        public new event EventHandler Click;

        public ClockPoint()
        {
            InitializeComponent();
        }

        public string LabelText
        {
            get
            {
                return this.label.Text;
            }
            set
            {
                this.label.Text = value;
            }
        }

        private void Label_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter?.Invoke(this, EventArgs.Empty);
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave?.Invoke(this, EventArgs.Empty);
        }

        private void Label_Click(object sender, EventArgs e)
        {
            Click?.Invoke(this, EventArgs.Empty);
        }
    }
}
