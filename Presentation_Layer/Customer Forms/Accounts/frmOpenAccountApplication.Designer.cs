namespace Presentation_Layer.Customer_Forms.Accounts
{
    partial class frmOpenAccountApplication
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblFees = new Label();
            lblDescription = new Label();
            lblBalance = new Label();
            lblAccountID = new Label();
            label7 = new Label();
            label8 = new Label();
            label12 = new Label();
            lblStatus = new Label();
            label11 = new Label();
            label6 = new Label();
            lblCreatedDate = new Label();
            label10 = new Label();
            btnCreate = new Button();
            btnClose = new Button();
            comboBox2 = new ComboBox();
            tbAccountNumber = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(167, 144);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(237, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(21, 141);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 1;
            label1.Text = "Account Type:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(102, 18);
            label2.Name = "label2";
            label2.Size = new Size(414, 37);
            label2.TabIndex = 2;
            label2.Text = "Create New Account Application";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(22, 236);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 3;
            label3.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(22, 305);
            label4.Name = "label4";
            label4.Size = new Size(51, 25);
            label4.TabIndex = 4;
            label4.Text = "Fees:";
            // 
            // lblFees
            // 
            lblFees.AutoSize = true;
            lblFees.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFees.Location = new Point(214, 302);
            lblFees.Name = "lblFees";
            lblFees.Size = new Size(40, 20);
            lblFees.TabIndex = 6;
            lblFees.Text = "[???]";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(214, 236);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(34, 17);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "[???]";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 13F);
            lblBalance.Location = new Point(681, 302);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(46, 25);
            lblBalance.TabIndex = 10;
            lblBalance.Text = "[???]";
            // 
            // lblAccountID
            // 
            lblAccountID.AutoSize = true;
            lblAccountID.Font = new Font("Segoe UI", 13F);
            lblAccountID.Location = new Point(681, 242);
            lblAccountID.Name = "lblAccountID";
            lblAccountID.Size = new Size(46, 25);
            lblAccountID.TabIndex = 9;
            lblAccountID.Text = "[???]";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F);
            label7.Location = new Point(489, 302);
            label7.Name = "label7";
            label7.Size = new Size(75, 25);
            label7.TabIndex = 8;
            label7.Text = "Balance:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13F);
            label8.Location = new Point(489, 242);
            label8.Name = "label8";
            label8.Size = new Size(104, 25);
            label8.TabIndex = 7;
            label8.Text = "Account ID:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13F);
            label12.Location = new Point(489, 362);
            label12.Name = "label12";
            label12.Size = new Size(151, 25);
            label12.TabIndex = 11;
            label12.Text = "Account Number:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 13F);
            lblStatus.Location = new Point(681, 422);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(46, 25);
            lblStatus.TabIndex = 15;
            lblStatus.Text = "[???]";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13F);
            label11.Location = new Point(489, 422);
            label11.Name = "label11";
            label11.Size = new Size(64, 25);
            label11.TabIndex = 14;
            label11.Text = "Status:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F);
            label6.Location = new Point(22, 363);
            label6.Name = "label6";
            label6.Size = new Size(85, 25);
            label6.TabIndex = 16;
            label6.Text = "Currency:";
            // 
            // lblCreatedDate
            // 
            lblCreatedDate.AutoSize = true;
            lblCreatedDate.Font = new Font("Segoe UI", 13F);
            lblCreatedDate.Location = new Point(214, 422);
            lblCreatedDate.Name = "lblCreatedDate";
            lblCreatedDate.Size = new Size(46, 25);
            lblCreatedDate.TabIndex = 19;
            lblCreatedDate.Text = "[???]";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13F);
            label10.Location = new Point(22, 422);
            label10.Name = "label10";
            label10.Size = new Size(119, 25);
            label10.TabIndex = 18;
            label10.Text = "Created Date:";
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI", 18F);
            btnCreate.Location = new Point(480, 667);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(146, 44);
            btnCreate.TabIndex = 20;
            btnCreate.Text = "CREATE";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 18F);
            btnClose.Location = new Point(323, 667);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(146, 44);
            btnClose.TabIndex = 21;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(167, 366);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(237, 23);
            comboBox2.TabIndex = 22;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // tbAccountNumber
            // 
            tbAccountNumber.Location = new Point(681, 364);
            tbAccountNumber.Name = "tbAccountNumber";
            tbAccountNumber.Size = new Size(139, 23);
            tbAccountNumber.TabIndex = 23;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmOpenAccountApplication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 723);
            Controls.Add(tbAccountNumber);
            Controls.Add(comboBox2);
            Controls.Add(btnClose);
            Controls.Add(btnCreate);
            Controls.Add(lblCreatedDate);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(lblStatus);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(lblBalance);
            Controls.Add(lblAccountID);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(lblFees);
            Controls.Add(lblDescription);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "frmOpenAccountApplication";
            Text = "frmOpenAccountApplication";
            Load += frmOpenAccountApplication_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblFees;
        private Label lblDescription;
        private Label lblBalance;
        private Label lblAccountID;
        private Label label7;
        private Label label8;
        private Label label12;
        private Label lblStatus;
        private Label label11;
        private Label label6;
        private Label lblCreatedDate;
        private Label label10;
        private Button btnCreate;
        private Button btnClose;
        private ComboBox comboBox2;
        private TextBox tbAccountNumber;
        private ErrorProvider errorProvider1;
    }
}