namespace Presentation_Layer.User_Forms.Users
{
    partial class frmAddUpdateUser
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
            tabControl1 = new TabControl();
            tbPerson = new TabPage();
            btnNext = new Button();
            ctrlPersonInfoWithFilter1 = new People.Controls.ctrlPersonInfoWithFilter();
            tbUser = new TabPage();
            lblMode = new Label();
            lblUserID = new Label();
            label6 = new Label();
            chkIsActive = new CheckBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            tbRePassword = new TextBox();
            label3 = new Label();
            tbPassword = new CustomControls.ctrlTextBoxValidation();
            label2 = new Label();
            tbUserName = new CustomControls.ctrlTextBoxValidation();
            label1 = new Label();
            button1 = new Button();
            btnClose = new Button();
            errorProvider1 = new ErrorProvider(components);
            tabControl1.SuspendLayout();
            tbPerson.SuspendLayout();
            tbUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbPerson);
            tabControl1.Controls.Add(tbUser);
            tabControl1.Location = new Point(0, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(905, 512);
            tabControl1.TabIndex = 0;
            tabControl1.Selecting += tabControl1_Selecting;
            // 
            // tbPerson
            // 
            tbPerson.Controls.Add(btnNext);
            tbPerson.Controls.Add(ctrlPersonInfoWithFilter1);
            tbPerson.Location = new Point(4, 24);
            tbPerson.Name = "tbPerson";
            tbPerson.Padding = new Padding(3);
            tbPerson.Size = new Size(897, 484);
            tbPerson.TabIndex = 0;
            tbPerson.Text = "Person Info";
            tbPerson.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(799, 423);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(91, 54);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // ctrlPersonInfoWithFilter1
            // 
            ctrlPersonInfoWithFilter1.EnableFilter = true;
            ctrlPersonInfoWithFilter1.Location = new Point(3, 3);
            ctrlPersonInfoWithFilter1.Name = "ctrlPersonInfoWithFilter1";
            ctrlPersonInfoWithFilter1.Size = new Size(891, 471);
            ctrlPersonInfoWithFilter1.TabIndex = 0;
            ctrlPersonInfoWithFilter1.Load += ctrlPersonInfoWithFilter1_Load;
            // 
            // tbUser
            // 
            tbUser.Controls.Add(lblMode);
            tbUser.Controls.Add(lblUserID);
            tbUser.Controls.Add(label6);
            tbUser.Controls.Add(chkIsActive);
            tbUser.Controls.Add(label5);
            tbUser.Controls.Add(comboBox1);
            tbUser.Controls.Add(label4);
            tbUser.Controls.Add(tbRePassword);
            tbUser.Controls.Add(label3);
            tbUser.Controls.Add(tbPassword);
            tbUser.Controls.Add(label2);
            tbUser.Controls.Add(tbUserName);
            tbUser.Controls.Add(label1);
            tbUser.Controls.Add(button1);
            tbUser.Location = new Point(4, 24);
            tbUser.Name = "tbUser";
            tbUser.Padding = new Padding(3);
            tbUser.Size = new Size(897, 484);
            tbUser.TabIndex = 1;
            tbUser.Text = "User Info";
            tbUser.UseVisualStyleBackColor = true;
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMode.Location = new Point(421, 22);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(48, 25);
            lblMode.TabIndex = 15;
            lblMode.Text = "[???]";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserID.Location = new Point(193, 95);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(48, 25);
            lblUserID.TabIndex = 14;
            lblUserID.Text = "[???]";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(36, 95);
            label6.Name = "label6";
            label6.Size = new Size(80, 25);
            label6.TabIndex = 13;
            label6.Text = "User ID:";
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Checked = true;
            chkIsActive.CheckState = CheckState.Checked;
            chkIsActive.Font = new Font("Segoe UI", 12F);
            chkIsActive.Location = new Point(626, 169);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(15, 14);
            chkIsActive.TabIndex = 12;
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(508, 158);
            label5.Name = "label5";
            label5.Size = new Size(90, 25);
            label5.TabIndex = 11;
            label5.Text = "Is Active:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "User", "Admin" });
            comboBox1.Location = new Point(193, 382);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(154, 23);
            comboBox1.TabIndex = 10;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(36, 380);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 9;
            label4.Text = "Role:";
            // 
            // tbRePassword
            // 
            tbRePassword.Location = new Point(193, 281);
            tbRePassword.Name = "tbRePassword";
            tbRePassword.PasswordChar = '*';
            tbRePassword.Size = new Size(154, 23);
            tbRePassword.TabIndex = 8;
            tbRePassword.TextChanged += tbRePassword_TextChanged;
            tbRePassword.Validating += textBox1_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(36, 281);
            label3.Name = "label3";
            label3.Size = new Size(125, 25);
            label3.TabIndex = 7;
            label3.Text = "Re-Password:";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(193, 236);
            tbPassword.MinCharLength = 4;
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Pattern = CustomControls.ctrlTextBoxValidation.enPattern.Password;
            tbPassword.RegExp = "^[a-zA-Z0-9]{4,}$";
            tbPassword.Size = new Size(154, 23);
            tbPassword.TabIndex = 6;
            tbPassword.Validating += tbPassword_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 236);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 5;
            label2.Text = "Password:";
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(193, 160);
            tbUserName.MinCharLength = 1;
            tbUserName.Name = "tbUserName";
            tbUserName.Pattern = CustomControls.ctrlTextBoxValidation.enPattern.Username;
            tbUserName.RegExp = "^[a-zA-Z0-9]{3,16}$";
            tbUserName.Size = new Size(154, 23);
            tbUserName.TabIndex = 4;
            tbUserName.Tag = "User";
            tbUserName.Validating += tbUserName_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 158);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 3;
            label1.Text = "User Name:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(799, 424);
            button1.Name = "button1";
            button1.Size = new Size(91, 54);
            button1.TabIndex = 2;
            button1.Text = "CREATE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(803, 571);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(91, 54);
            btnClose.TabIndex = 1;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdateUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 637);
            Controls.Add(btnClose);
            Controls.Add(tabControl1);
            Name = "frmAddUpdateUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User";
            Load += frmAddUpdateUser_Load;
            tabControl1.ResumeLayout(false);
            tbPerson.ResumeLayout(false);
            tbUser.ResumeLayout(false);
            tbUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tbPerson;
        private People.Controls.ctrlPersonInfoWithFilter ctrlPersonInfoWithFilter1;
        private TabPage tbUser;
        private Button btnNext;
        private Button btnClose;
        private Button button1;
        private CustomControls.ctrlTextBoxValidation tbUserName;
        private Label label1;
        private TextBox tbRePassword;
        private Label label3;
        private CustomControls.ctrlTextBoxValidation tbPassword;
        private Label label2;
        private ComboBox comboBox1;
        private Label label4;
        private ErrorProvider errorProvider1;
        private CheckBox chkIsActive;
        private Label label5;
        private Label lblUserID;
        private Label label6;
        private Label lblMode;
    }
}