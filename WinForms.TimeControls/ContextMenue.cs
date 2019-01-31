using System.Drawing;

namespace System.Windows.Forms.TimeControls
{
    class ContextMenue : ContextMenuStrip
    {
        public void Show(Point screenLocation, Control control)
        {
            this.Items.Clear();

            ToolStripControlHost toolStripHost = new ToolStripControlHost(control)
            {
                BackColor = Color.Black
            };

            this.BackColor = System.Drawing.Color.Black;

            this.Items.Add(toolStripHost);
            
            base.Show(screenLocation);
        }       
    }
}
