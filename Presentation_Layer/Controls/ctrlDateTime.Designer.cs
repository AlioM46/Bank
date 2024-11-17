namespace Presentation_Layer.Controls
{
    partial class ctrlDateTime
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
            components = new System.ComponentModel.Container();
            gb1 = new GroupBox();
            lblDate = new Label();
            lblTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            gb1.SuspendLayout();
            SuspendLayout();
            // 
            // gb1
            // 
            gb1.Controls.Add(lblDate);
            gb1.Controls.Add(lblTime);
            gb1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gb1.Location = new Point(12, 12);
            gb1.Name = "gb1";
            gb1.Size = new Size(397, 292);
            gb1.TabIndex = 0;
            gb1.TabStop = false;
            gb1.Text = "Date&&Time";
            gb1.Enter += gb1_Enter;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(127, 168);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(84, 45);
            lblDate.TabIndex = 1;
            lblDate.Text = "[???]";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTime.Location = new Point(127, 56);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(84, 45);
            lblTime.TabIndex = 0;
            lblTime.Text = "[???]";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // ctrlDateTime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gb1);
            Name = "ctrlDateTime";
            Size = new Size(424, 326);
            Load += ctrlDateTime_Load;
            gb1.ResumeLayout(false);
            gb1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb1;
        private Label lblDate;
        private Label lblTime;
        private System.Windows.Forms.Timer timer1;
    }
}
