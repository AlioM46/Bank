namespace Presentation_Layer.User_Forms.Users.Controls
{
    partial class ctrlUserInfo
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
            lblCreatedDate = new Label();
            label10 = new Label();
            lblIsActive = new Label();
            label6 = new Label();
            lblRole = new Label();
            label8 = new Label();
            lblUsername = new Label();
            label4 = new Label();
            lblUserID = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblCreatedDate
            // 
            lblCreatedDate.AutoSize = true;
            lblCreatedDate.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreatedDate.Location = new Point(559, 198);
            lblCreatedDate.Name = "lblCreatedDate";
            lblCreatedDate.Size = new Size(48, 25);
            lblCreatedDate.TabIndex = 20;
            lblCreatedDate.Text = "[???]";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(376, 198);
            label10.Name = "label10";
            label10.Size = new Size(130, 25);
            label10.TabIndex = 19;
            label10.Text = "Created Date:";
            // 
            // lblIsActive
            // 
            lblIsActive.AutoSize = true;
            lblIsActive.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIsActive.Location = new Point(559, 128);
            lblIsActive.Name = "lblIsActive";
            lblIsActive.Size = new Size(48, 25);
            lblIsActive.TabIndex = 18;
            lblIsActive.Text = "[???]";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(376, 128);
            label6.Name = "label6";
            label6.Size = new Size(90, 25);
            label6.TabIndex = 17;
            label6.Text = "Is Active:";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(559, 65);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(48, 25);
            lblRole.TabIndex = 16;
            lblRole.Text = "[???]";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(376, 65);
            label8.Name = "label8";
            label8.Size = new Size(54, 25);
            label8.TabIndex = 15;
            label8.Text = "Role:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(202, 130);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(48, 25);
            lblUsername.TabIndex = 14;
            lblUsername.Text = "[???]";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(70, 130);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 13;
            label4.Text = "User Name:";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserID.Location = new Point(202, 67);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(48, 25);
            lblUserID.TabIndex = 12;
            lblUserID.Text = "[???]";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 67);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 11;
            label1.Text = "User ID:";
            // 
            // ctrlUserInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblCreatedDate);
            Controls.Add(label10);
            Controls.Add(lblIsActive);
            Controls.Add(label6);
            Controls.Add(lblRole);
            Controls.Add(label8);
            Controls.Add(lblUsername);
            Controls.Add(label4);
            Controls.Add(lblUserID);
            Controls.Add(label1);
            Name = "ctrlUserInfo";
            Size = new Size(834, 270);
            Load += ctrlUserInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCreatedDate;
        private Label label10;
        private Label lblIsActive;
        private Label label6;
        private Label lblRole;
        private Label label8;
        private Label lblUsername;
        private Label label4;
        private Label lblUserID;
        private Label label1;
    }
}
