using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.timePicker1 = new TimePicker();
            this.clockControl1 = new ClockControl();
            this.SuspendLayout();
            // 
            // timePicker1
            // 
            this.timePicker1.Location = new System.Drawing.Point(407, 75);
            this.timePicker1.Name = "timePicker1";
            this.timePicker1.Size = new System.Drawing.Size(136, 54);
            this.timePicker1.TabIndex = 2;
            this.timePicker1.TimeChanged += new System.EventHandler<TimePickerEventArgs>(this.TimePicker1_TimeChanged);
            // 
            // clockControl1
            // 
            this.clockControl1.BackColor = System.Drawing.Color.Black;
            this.clockControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clockControl1.Location = new System.Drawing.Point(67, 75);
            this.clockControl1.Name = "clockControl1";
            this.clockControl1.Size = new System.Drawing.Size(150, 152);
            this.clockControl1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clockControl1);
            this.Controls.Add(this.timePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private TimePicker timePicker1;
        private ClockControl clockControl1;
    }
}

