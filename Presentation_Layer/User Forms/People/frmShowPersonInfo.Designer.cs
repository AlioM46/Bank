namespace Presentation_Layer.User_Forms.People
{
    partial class frmShowPersonInfo
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
            ctrlPersonInfo1 = new Controls.ctrlPersonInfo();
            button1 = new Button();
            SuspendLayout();
            // 
            // ctrlPersonInfo1
            // 
            ctrlPersonInfo1.Location = new Point(12, 3);
            ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            ctrlPersonInfo1.Size = new Size(830, 371);
            ctrlPersonInfo1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16F);
            button1.Location = new Point(719, 380);
            button1.Name = "button1";
            button1.Size = new Size(123, 57);
            button1.TabIndex = 2;
            button1.Text = "CLOSE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmShowPersonInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 445);
            Controls.Add(button1);
            Controls.Add(ctrlPersonInfo1);
            Name = "frmShowPersonInfo";
            Text = "frmShowPersonInfo";
            Load += frmShowPersonInfo_Load;
            ResumeLayout(false);
        }

        #endregion

        private Controls.ctrlPersonInfo ctrlPersonInfo1;
        private Button button1;
    }
}