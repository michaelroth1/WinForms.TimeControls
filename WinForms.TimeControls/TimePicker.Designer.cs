namespace System.Windows.Forms
{
    partial class TimePicker
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
            this.hoursLabel = new System.Windows.Forms.Label();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenue = new TimeControls.ContextMenue();
            this.SuspendLayout();
            // 
            // hoursLabel
            // 
            this.hoursLabel.BackColor = System.Drawing.Color.Transparent;
            this.hoursLabel.Font = new System.Drawing.Font("Segoe UI Light", 22.75F);
            this.hoursLabel.ForeColor = System.Drawing.Color.Gray;
            this.hoursLabel.Location = new System.Drawing.Point(5, 5);
            this.hoursLabel.Margin = new System.Windows.Forms.Padding(5);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(61, 44);
            this.hoursLabel.TabIndex = 17;
            this.hoursLabel.Text = "23";
            this.hoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hoursLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelHour_MouseClick);
            // 
            // minutesLabel
            // 
            this.minutesLabel.BackColor = System.Drawing.Color.Transparent;
            this.minutesLabel.Font = new System.Drawing.Font("Segoe UI Light", 22.75F);
            this.minutesLabel.ForeColor = System.Drawing.Color.Gray;
            this.minutesLabel.Location = new System.Drawing.Point(70, 5);
            this.minutesLabel.Margin = new System.Windows.Forms.Padding(5);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(58, 44);
            this.minutesLabel.TabIndex = 16;
            this.minutesLabel.Text = "59";
            this.minutesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.minutesLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelMinutes_MouseClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 22.75F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(56, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 49);
            this.label1.TabIndex = 18;
            this.label1.Text = ":";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenue
            // 
            this.contextMenue.BackColor = System.Drawing.Color.Transparent;
            this.contextMenue.Name = "myContextMenue1";
            this.contextMenue.ShowImageMargin = false;
            this.contextMenue.ShowItemToolTips = false;
            this.contextMenue.Size = new System.Drawing.Size(36, 4);
            // 
            // TimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.minutesLabel);
            this.Controls.Add(this.label1);
            this.Name = "TimePicker";
            this.Size = new System.Drawing.Size(136, 54);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label label1;
        private TimeControls.ContextMenue contextMenue;
    }
}
