namespace Presentation_Layer.User_Forms.Users
{
    partial class frmShowUserInfo
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
            ctrlPersonInfo1 = new People.Controls.ctrlPersonInfo();
            ctrlUserInfo1 = new Controls.ctrlUserInfo();
            button1 = new Button();
            SuspendLayout();
            // 
            // ctrlPersonInfo1
            // 
            ctrlPersonInfo1.Location = new Point(3, 290);
            ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            ctrlPersonInfo1.Size = new Size(830, 371);
            ctrlPersonInfo1.TabIndex = 0;
            ctrlPersonInfo1.Load += ctrlPersonInfo1_Load;
            // 
            // ctrlUserInfo1
            // 
            ctrlUserInfo1.Location = new Point(3, 14);
            ctrlUserInfo1.Name = "ctrlUserInfo1";
            ctrlUserInfo1.Size = new Size(834, 270);
            ctrlUserInfo1.TabIndex = 1;
            ctrlUserInfo1.Load += ctrlUserInfo1_Load;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16F);
            button1.Location = new Point(683, 681);
            button1.Name = "button1";
            button1.Size = new Size(140, 50);
            button1.TabIndex = 2;
            button1.Text = "CLOSE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmShowUserInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 743);
            Controls.Add(button1);
            Controls.Add(ctrlUserInfo1);
            Controls.Add(ctrlPersonInfo1);
            Name = "frmShowUserInfo";
            Text = "frmShowUserInfo";
            Load += frmShowUserInfo_Load;
            ResumeLayout(false);
        }

        #endregion

        private People.Controls.ctrlPersonInfo ctrlPersonInfo1;
        private Controls.ctrlUserInfo ctrlUserInfo1;
        private Button button1;
    }
}