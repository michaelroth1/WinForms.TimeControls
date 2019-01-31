namespace System.Windows.Forms
{
    partial class MinutesPicker
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clockControl = new ClockControl();
            this.SuspendLayout();
            // 
            // clockControl1
            // 
            this.clockControl.BackColor = System.Drawing.Color.Black;
            this.clockControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clockControl.Location = new System.Drawing.Point(0, 0);
            this.clockControl.Name = "clockControl1";
            this.clockControl.Size = new System.Drawing.Size(150, 152);
            this.clockControl.TabIndex = 0;
            this.clockControl.TimeChanged += new System.EventHandler<ClockEventArgs>(this.ClockControl_TimeChanged);
            this.clockControl.ClockHover += new System.EventHandler<ClockEventArgs>(this.ClockControl_ClockHover);
            this.clockControl.ClockInitialized += new System.EventHandler<System.EventArgs>(this.ClockControl_ClockInitialized);
            // 
            // MinutesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clockControl);
            this.Name = "MinutesControl";
            this.ResumeLayout(false);

        }

        #endregion

        private ClockControl clockControl;
    }
}
