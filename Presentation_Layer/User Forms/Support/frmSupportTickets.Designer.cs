namespace Presentation_Layer.User_Forms
{
    partial class frmSupportTickets
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
            tbFilter = new TextBox();
            label1 = new Label();
            cbFilter = new ComboBox();
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            SuspendLayout();
            // 
            // tbFilter
            // 
            tbFilter.Font = new Font("Segoe UI", 12F);
            tbFilter.Location = new Point(429, 124);
            tbFilter.Name = "tbFilter";
            tbFilter.Size = new Size(393, 29);
            tbFilter.TabIndex = 0;
            tbFilter.TextChanged += tbFilter_TextChanged;
            tbFilter.KeyPress += tbFilter_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 109);
            label1.Name = "label1";
            label1.Size = new Size(130, 37);
            label1.TabIndex = 1;
            label1.Text = "Filter By:";
            // 
            // cbFilter
            // 
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.Font = new Font("Segoe UI", 12F);
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "None", "Ticket ID", "Publisher ID", "Responser ID", "Subject", "Description" });
            cbFilter.Location = new Point(189, 123);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(215, 29);
            cbFilter.TabIndex = 2;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold);
            label2.Location = new Point(738, 9);
            label2.Name = "label2";
            label2.Size = new Size(281, 47);
            label2.TabIndex = 3;
            label2.Text = "Support Tickets";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Location = new Point(16, 239);
            panel1.Name = "panel1";
            panel1.Size = new Size(1874, 740);
            panel1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(346, 214);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // frmSupportTickets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 991);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(cbFilter);
            Controls.Add(label1);
            Controls.Add(tbFilter);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1918, 1030);
            Name = "frmSupportTickets";
            StartPosition = FormStartPosition.Manual;
            Text = "Support Tickets";
            WindowState = FormWindowState.Maximized;
            Load += frmSupportTickets_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbFilter;
        private Label label1;
        private ComboBox cbFilter;
        private Label label2;
        private Panel panel1;
        private Label label3;
    }
}