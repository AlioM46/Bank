namespace Presentation_Layer.User_Forms.Customers.Controls
{
    partial class ctrlChangeCustomerInfo
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
            label7 = new Label();
            lblCustomerID = new Label();
            label6 = new Label();
            chkIsActive = new CheckBox();
            label5 = new Label();
            tbRePassword = new TextBox();
            label3 = new Label();
            tbPassword = new CustomControls.ctrlTextBoxValidation();
            label2 = new Label();
            tbCustomerName = new CustomControls.ctrlTextBoxValidation();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblCreatedDate
            // 
            lblCreatedDate.AutoSize = true;
            lblCreatedDate.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreatedDate.Location = new Point(652, 163);
            lblCreatedDate.Name = "lblCreatedDate";
            lblCreatedDate.Size = new Size(48, 25);
            lblCreatedDate.TabIndex = 29;
            lblCreatedDate.Text = "[???]";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(495, 163);
            label7.Name = "label7";
            label7.Size = new Size(130, 25);
            label7.TabIndex = 28;
            label7.Text = "Created Date:";
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerID.Location = new Point(180, 29);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(48, 25);
            lblCustomerID.TabIndex = 27;
            lblCustomerID.Text = "[???]";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(23, 29);
            label6.Name = "label6";
            label6.Size = new Size(125, 25);
            label6.TabIndex = 26;
            label6.Text = "Customer ID:";
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Checked = true;
            chkIsActive.CheckState = CheckState.Checked;
            chkIsActive.Font = new Font("Segoe UI", 12F);
            chkIsActive.Location = new Point(613, 103);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(15, 14);
            chkIsActive.TabIndex = 25;
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(495, 92);
            label5.Name = "label5";
            label5.Size = new Size(90, 25);
            label5.TabIndex = 24;
            label5.Text = "Is Active:";
            // 
            // tbRePassword
            // 
            tbRePassword.Location = new Point(207, 213);
            tbRePassword.Name = "tbRePassword";
            tbRePassword.PasswordChar = '*';
            tbRePassword.Size = new Size(154, 23);
            tbRePassword.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 215);
            label3.Name = "label3";
            label3.Size = new Size(125, 25);
            label3.TabIndex = 22;
            label3.Text = "Re-Password:";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(207, 168);
            tbPassword.MinCharLength = 4;
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Pattern = CustomControls.ctrlTextBoxValidation.enPattern.Password;
            tbPassword.RegExp = "^[a-zA-Z0-9]{4,}$";
            tbPassword.Size = new Size(154, 23);
            tbPassword.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 170);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 20;
            label2.Text = "Password:";
            // 
            // tbCustomerName
            // 
            tbCustomerName.Location = new Point(207, 92);
            tbCustomerName.MinCharLength = 1;
            tbCustomerName.Name = "tbCustomerName";
            tbCustomerName.Pattern = CustomControls.ctrlTextBoxValidation.enPattern.Username;
            tbCustomerName.RegExp = "^[a-zA-Z0-9]{3,16}$";
            tbCustomerName.Size = new Size(154, 23);
            tbCustomerName.TabIndex = 19;
            tbCustomerName.Tag = "User";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 90);
            label1.Name = "label1";
            label1.Size = new Size(157, 25);
            label1.TabIndex = 18;
            label1.Text = "Customer Name:";
            // 
            // ctrlChangeCustomerInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblCreatedDate);
            Controls.Add(label7);
            Controls.Add(lblCustomerID);
            Controls.Add(label6);
            Controls.Add(chkIsActive);
            Controls.Add(label5);
            Controls.Add(tbRePassword);
            Controls.Add(label3);
            Controls.Add(tbPassword);
            Controls.Add(label2);
            Controls.Add(tbCustomerName);
            Controls.Add(label1);
            Name = "ctrlChangeCustomerInfo";
            Size = new Size(727, 298);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCreatedDate;
        private Label label7;
        private Label lblCustomerID;
        private Label label6;
        private CheckBox chkIsActive;
        private Label label5;
        private TextBox tbRePassword;
        private Label label3;
        private CustomControls.ctrlTextBoxValidation tbPassword;
        private Label label2;
        private CustomControls.ctrlTextBoxValidation tbCustomerName;
        private Label label1;
    }
}
