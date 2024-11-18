namespace Presentation_Layer.LoginForm
{
    partial class frmLogin
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
            components = new System.ComponentModel.Container();
            errorProvider1 = new ErrorProvider(components);
            tpAdminLogin = new TabPage();
            chkRememberMeUser = new CheckBox();
            btnUserLogin = new Button();
            tbPasswordUserLogin = new CustomControls.ctrlTextBoxValidation();
            tbUserNameLogin = new CustomControls.ctrlTextBoxValidation();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            tpLogin = new TabPage();
            chkRememberMeCustomer = new CheckBox();
            btnCustomerLogin = new Button();
            tbPasswordLogin = new CustomControls.ctrlTextBoxValidation();
            tbCustomerNameLogin = new CustomControls.ctrlTextBoxValidation();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabControl1 = new TabControl();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            tpAdminLogin.SuspendLayout();
            tpLogin.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // tpAdminLogin
            // 
            tpAdminLogin.Controls.Add(chkRememberMeUser);
            tpAdminLogin.Controls.Add(btnUserLogin);
            tpAdminLogin.Controls.Add(tbPasswordUserLogin);
            tpAdminLogin.Controls.Add(tbUserNameLogin);
            tpAdminLogin.Controls.Add(label7);
            tpAdminLogin.Controls.Add(label8);
            tpAdminLogin.Controls.Add(label9);
            tpAdminLogin.Font = new Font("Segoe UI", 12F);
            tpAdminLogin.Location = new Point(4, 24);
            tpAdminLogin.Name = "tpAdminLogin";
            tpAdminLogin.Size = new Size(649, 505);
            tpAdminLogin.TabIndex = 2;
            tpAdminLogin.Text = "Admin's Login";
            tpAdminLogin.UseVisualStyleBackColor = true;
            tpAdminLogin.Click += tpAdminLogin_Click;
            // 
            // chkRememberMeUser
            // 
            chkRememberMeUser.AutoSize = true;
            chkRememberMeUser.Checked = true;
            chkRememberMeUser.CheckState = CheckState.Checked;
            chkRememberMeUser.Location = new Point(315, 288);
            chkRememberMeUser.Name = "chkRememberMeUser";
            chkRememberMeUser.Size = new Size(132, 25);
            chkRememberMeUser.TabIndex = 14;
            chkRememberMeUser.Text = "Remember Me";
            chkRememberMeUser.UseVisualStyleBackColor = true;
            chkRememberMeUser.CheckedChanged += chkRememberMeUser_CheckedChanged;
            // 
            // btnUserLogin
            // 
            btnUserLogin.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUserLogin.Location = new Point(521, 270);
            btnUserLogin.Name = "btnUserLogin";
            btnUserLogin.Size = new Size(112, 43);
            btnUserLogin.TabIndex = 13;
            btnUserLogin.Text = "Login";
            btnUserLogin.UseVisualStyleBackColor = true;
            btnUserLogin.Click += btnUserLogin_Click;
            // 
            // tbPasswordUserLogin
            // 
            tbPasswordUserLogin.BackColor = Color.LightCoral;
            tbPasswordUserLogin.Location = new Point(243, 226);
            tbPasswordUserLogin.MinCharLength = 4;
            tbPasswordUserLogin.Name = "tbPasswordUserLogin";
            tbPasswordUserLogin.Pattern = CustomControls.ctrlTextBoxValidation.enPattern.Password;
            tbPasswordUserLogin.RegExp = "^[a-zA-Z0-9]{4,}$";
            tbPasswordUserLogin.Size = new Size(204, 29);
            tbPasswordUserLogin.TabIndex = 12;
            tbPasswordUserLogin.Validating += TextBoxValidation;
            // 
            // tbUserNameLogin
            // 
            tbUserNameLogin.BackColor = Color.LightCoral;
            tbUserNameLogin.Location = new Point(243, 149);
            tbUserNameLogin.MinCharLength = 8;
            tbUserNameLogin.Name = "tbUserNameLogin";
            tbUserNameLogin.Pattern = CustomControls.ctrlTextBoxValidation.enPattern.Username;
            tbUserNameLogin.RegExp = "";
            tbUserNameLogin.Size = new Size(204, 29);
            tbUserNameLogin.TabIndex = 11;
            tbUserNameLogin.Validating += TextBoxValidation;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Rockwell", 18F);
            label7.Location = new Point(273, 20);
            label7.Name = "label7";
            label7.Size = new Size(147, 27);
            label7.TabIndex = 10;
            label7.Text = "User's Login";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(100, 226);
            label8.Name = "label8";
            label8.Size = new Size(84, 19);
            label8.TabIndex = 9;
            label8.Text = "Password:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(100, 154);
            label9.Name = "label9";
            label9.Size = new Size(96, 19);
            label9.TabIndex = 8;
            label9.Text = "User Name:";
            // 
            // tpLogin
            // 
            tpLogin.Controls.Add(chkRememberMeCustomer);
            tpLogin.Controls.Add(btnCustomerLogin);
            tpLogin.Controls.Add(tbPasswordLogin);
            tpLogin.Controls.Add(tbCustomerNameLogin);
            tpLogin.Controls.Add(label3);
            tpLogin.Controls.Add(label2);
            tpLogin.Controls.Add(label1);
            tpLogin.Font = new Font("Segoe UI", 12F);
            tpLogin.Location = new Point(4, 24);
            tpLogin.Name = "tpLogin";
            tpLogin.Padding = new Padding(3);
            tpLogin.Size = new Size(649, 505);
            tpLogin.TabIndex = 0;
            tpLogin.Text = "Login";
            tpLogin.UseVisualStyleBackColor = true;
            // 
            // chkRememberMeCustomer
            // 
            chkRememberMeCustomer.AutoSize = true;
            chkRememberMeCustomer.Checked = true;
            chkRememberMeCustomer.CheckState = CheckState.Checked;
            chkRememberMeCustomer.Location = new Point(308, 293);
            chkRememberMeCustomer.Name = "chkRememberMeCustomer";
            chkRememberMeCustomer.Size = new Size(132, 25);
            chkRememberMeCustomer.TabIndex = 8;
            chkRememberMeCustomer.Text = "Remember Me";
            chkRememberMeCustomer.UseVisualStyleBackColor = true;
            chkRememberMeCustomer.CheckedChanged += chkRememberMeCustomer_CheckedChanged;
            // 
            // btnCustomerLogin
            // 
            btnCustomerLogin.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCustomerLogin.Location = new Point(513, 275);
            btnCustomerLogin.Name = "btnCustomerLogin";
            btnCustomerLogin.Size = new Size(112, 43);
            btnCustomerLogin.TabIndex = 7;
            btnCustomerLogin.Text = "Login";
            btnCustomerLogin.UseVisualStyleBackColor = true;
            btnCustomerLogin.Click += btnCustomerLogin_Click;
            // 
            // tbPasswordLogin
            // 
            tbPasswordLogin.BackColor = Color.LightCoral;
            tbPasswordLogin.Location = new Point(236, 217);
            tbPasswordLogin.MinCharLength = 8;
            tbPasswordLogin.Name = "tbPasswordLogin";
            tbPasswordLogin.Pattern = CustomControls.ctrlTextBoxValidation.enPattern.Password;
            tbPasswordLogin.RegExp = "^[a-zA-Z]{6,16}$";
            tbPasswordLogin.Size = new Size(204, 29);
            tbPasswordLogin.TabIndex = 6;
            tbPasswordLogin.TextChanged += tbPasswordLogin_TextChanged;
            tbPasswordLogin.Validating += TextBoxValidation;
            // 
            // tbCustomerNameLogin
            // 
            tbCustomerNameLogin.BackColor = Color.LightCoral;
            tbCustomerNameLogin.Location = new Point(236, 145);
            tbCustomerNameLogin.MinCharLength = 8;
            tbCustomerNameLogin.Name = "tbCustomerNameLogin";
            tbCustomerNameLogin.Pattern = CustomControls.ctrlTextBoxValidation.enPattern.Username;
            tbCustomerNameLogin.RegExp = "^[a-zA-Z0-9]{3,16}$";
            tbCustomerNameLogin.Size = new Size(204, 29);
            tbCustomerNameLogin.TabIndex = 5;
            tbCustomerNameLogin.TextChanged += ctrlTextBoxValidation1_TextChanged;
            tbCustomerNameLogin.Validating += TextBoxValidation;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 18F);
            label3.Location = new Point(296, 27);
            label3.Name = "label3";
            label3.Size = new Size(75, 27);
            label3.TabIndex = 4;
            label3.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(75, 217);
            label2.Name = "label2";
            label2.Size = new Size(84, 19);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(75, 145);
            label1.Name = "label1";
            label1.Size = new Size(134, 19);
            label1.TabIndex = 2;
            label1.Text = "Customer Name:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpLogin);
            tabControl1.Controls.Add(tpAdminLogin);
            tabControl1.Location = new Point(-5, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(657, 533);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 545);
            Controls.Add(tabControl1);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Login Page";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            tpAdminLogin.ResumeLayout(false);
            tpAdminLogin.PerformLayout();
            tpLogin.ResumeLayout(false);
            tpLogin.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ErrorProvider errorProvider1;
        private TabControl tabControl1;
        private TabPage tpLogin;
        private CustomControls.ctrlTextBoxValidation tbPasswordLogin;
        private CustomControls.ctrlTextBoxValidation tbCustomerNameLogin;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tpAdminLogin;
        private CustomControls.ctrlTextBoxValidation tbPasswordUserLogin;
        private CustomControls.ctrlTextBoxValidation tbUserNameLogin;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnCustomerLogin;
        private Button btnUserLogin;
        private CheckBox chkRememberMeCustomer;
        private CheckBox chkRememberMeUser;
        private CustomControls.ctrlTextBoxValidation asdasdasd;
    }
}