namespace Presentation_Layer.User_Forms.Customers
{
    partial class frmAddEditCustomer
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
            btnClose = new Button();
            lblMode = new Label();
            lblCustomerID = new Label();
            label6 = new Label();
            chkIsActive = new CheckBox();
            label5 = new Label();
            btnNext = new Button();
            ctrlPersonInfoWithFilter1 = new People.Controls.ctrlPersonInfoWithFilter();
            tbPerson = new TabPage();
            tbRePassword = new TextBox();
            label3 = new Label();
            tbPassword = new CustomControls.ctrlTextBoxValidation();
            label2 = new Label();
            tbCustomerName = new CustomControls.ctrlTextBoxValidation();
            label1 = new Label();
            button1 = new Button();
            tbCustomer = new TabPage();
            lblCreatedDate = new Label();
            label7 = new Label();
            tabControl1 = new TabControl();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            tbPerson.SuspendLayout();
            tbCustomer.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(807, 558);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(91, 54);
            btnClose.TabIndex = 3;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMode.Location = new Point(424, 25);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(48, 25);
            lblMode.TabIndex = 15;
            lblMode.Text = "[???]";
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerID.Location = new Point(196, 98);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(48, 25);
            lblCustomerID.TabIndex = 14;
            lblCustomerID.Text = "[???]";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(39, 98);
            label6.Name = "label6";
            label6.Size = new Size(125, 25);
            label6.TabIndex = 13;
            label6.Text = "Customer ID:";
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Checked = true;
            chkIsActive.CheckState = CheckState.Checked;
            chkIsActive.Font = new Font("Segoe UI", 12F);
            chkIsActive.Location = new Point(629, 172);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(15, 14);
            chkIsActive.TabIndex = 12;
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(511, 161);
            label5.Name = "label5";
            label5.Size = new Size(90, 25);
            label5.TabIndex = 11;
            label5.Text = "Is Active:";
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(800, 467);
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
            ctrlPersonInfoWithFilter1.Location = new Point(6, 0);
            ctrlPersonInfoWithFilter1.Name = "ctrlPersonInfoWithFilter1";
            ctrlPersonInfoWithFilter1.Size = new Size(891, 451);
            ctrlPersonInfoWithFilter1.TabIndex = 0;
            // 
            // tbPerson
            // 
            tbPerson.Controls.Add(btnNext);
            tbPerson.Controls.Add(ctrlPersonInfoWithFilter1);
            tbPerson.Location = new Point(4, 24);
            tbPerson.Name = "tbPerson";
            tbPerson.Padding = new Padding(3);
            tbPerson.Size = new Size(897, 527);
            tbPerson.TabIndex = 0;
            tbPerson.Text = "Person Info";
            tbPerson.UseVisualStyleBackColor = true;
            // 
            // tbRePassword
            // 
            tbRePassword.Location = new Point(223, 282);
            tbRePassword.Name = "tbRePassword";
            tbRePassword.PasswordChar = '*';
            tbRePassword.Size = new Size(154, 23);
            tbRePassword.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(39, 284);
            label3.Name = "label3";
            label3.Size = new Size(125, 25);
            label3.TabIndex = 7;
            label3.Text = "Re-Password:";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(223, 237);
            tbPassword.MinCharLength = 4;
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Pattern = CustomControls.ctrlTextBoxValidation.enPattern.Password;
            tbPassword.RegExp = "^[a-zA-Z0-9]{4,}$";
            tbPassword.Size = new Size(154, 23);
            tbPassword.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 239);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 5;
            label2.Text = "Password:";
            // 
            // tbCustomerName
            // 
            tbCustomerName.Location = new Point(223, 161);
            tbCustomerName.MinCharLength = 1;
            tbCustomerName.Name = "tbCustomerName";
            tbCustomerName.Pattern = CustomControls.ctrlTextBoxValidation.enPattern.Username;
            tbCustomerName.RegExp = "^[a-zA-Z0-9]{3,16}$";
            tbCustomerName.Size = new Size(154, 23);
            tbCustomerName.TabIndex = 4;
            tbCustomerName.Tag = "User";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 159);
            label1.Name = "label1";
            label1.Size = new Size(157, 25);
            label1.TabIndex = 3;
            label1.Text = "Customer Name:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(800, 467);
            button1.Name = "button1";
            button1.Size = new Size(91, 54);
            button1.TabIndex = 2;
            button1.Text = "CREATE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbCustomer
            // 
            tbCustomer.Controls.Add(lblCreatedDate);
            tbCustomer.Controls.Add(label7);
            tbCustomer.Controls.Add(lblMode);
            tbCustomer.Controls.Add(lblCustomerID);
            tbCustomer.Controls.Add(label6);
            tbCustomer.Controls.Add(chkIsActive);
            tbCustomer.Controls.Add(label5);
            tbCustomer.Controls.Add(tbRePassword);
            tbCustomer.Controls.Add(label3);
            tbCustomer.Controls.Add(tbPassword);
            tbCustomer.Controls.Add(label2);
            tbCustomer.Controls.Add(tbCustomerName);
            tbCustomer.Controls.Add(label1);
            tbCustomer.Controls.Add(button1);
            tbCustomer.Location = new Point(4, 24);
            tbCustomer.Name = "tbCustomer";
            tbCustomer.Padding = new Padding(3);
            tbCustomer.Size = new Size(897, 527);
            tbCustomer.TabIndex = 1;
            tbCustomer.Text = "Customer Info";
            tbCustomer.UseVisualStyleBackColor = true;
            // 
            // lblCreatedDate
            // 
            lblCreatedDate.AutoSize = true;
            lblCreatedDate.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreatedDate.Location = new Point(668, 232);
            lblCreatedDate.Name = "lblCreatedDate";
            lblCreatedDate.Size = new Size(48, 25);
            lblCreatedDate.TabIndex = 17;
            lblCreatedDate.Text = "[???]";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(511, 232);
            label7.Name = "label7";
            label7.Size = new Size(130, 25);
            label7.TabIndex = 16;
            label7.Text = "Created Date:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbPerson);
            tabControl1.Controls.Add(tbCustomer);
            tabControl1.Location = new Point(3, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(905, 555);
            tabControl1.TabIndex = 2;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            tabControl1.Selecting += tabControl1_Selecting;
            // 
            // frmAddEditCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 624);
            Controls.Add(btnClose);
            Controls.Add(tabControl1);
            Name = "frmAddEditCustomer";
            Text = "frmAddEditCustomer";
            Load += frmAddEditCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            tbPerson.ResumeLayout(false);
            tbCustomer.ResumeLayout(false);
            tbCustomer.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ErrorProvider errorProvider1;
        private Button btnClose;
        private TabControl tabControl1;
        private TabPage tbPerson;
        private Button btnNext;
        private People.Controls.ctrlPersonInfoWithFilter ctrlPersonInfoWithFilter1;
        private TabPage tbCustomer;
        private Label lblMode;
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
        private Button button1;
        private Label lblCreatedDate;
        private Label label7;
    }
}