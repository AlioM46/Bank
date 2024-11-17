namespace Presentation_Layer.User_Forms.Support
{
    partial class frmSupportResponse
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
            lblSubject = new Label();
            lblDescription = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubject.Location = new Point(12, 26);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(56, 30);
            lblSubject.TabIndex = 0;
            lblSubject.Text = "[???]";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 16F);
            lblDescription.Location = new Point(12, 106);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(57, 30);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "[???]";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(175, 208);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(323, 79);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(12, 199);
            label1.Name = "label1";
            label1.Size = new Size(110, 30);
            label1.TabIndex = 3;
            label1.Text = "Response:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16F);
            button1.Location = new Point(532, 334);
            button1.Name = "button1";
            button1.Size = new Size(121, 46);
            button1.TabIndex = 4;
            button1.Text = "Response";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmSupportResponse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 392);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(lblDescription);
            Controls.Add(lblSubject);
            Name = "frmSupportResponse";
            Text = "frmSupportResponse";
            Load += frmSupportResponse_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSubject;
        private Label lblDescription;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
    }
}