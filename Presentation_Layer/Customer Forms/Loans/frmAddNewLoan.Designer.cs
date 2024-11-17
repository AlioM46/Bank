namespace Presentation_Layer.Customer_Forms.Loans
{
    partial class frmAddNewLoan
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
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            lblMinAmount = new Label();
            label11 = new Label();
            lblMaxAmount = new Label();
            label9 = new Label();
            lblMonths = new Label();
            label7 = new Label();
            lblMinBalance = new Label();
            label4 = new Label();
            label3 = new Label();
            cbLoanTypes = new ComboBox();
            tbAmount = new TextBox();
            dtPickerStartDate = new DateTimePicker();
            dtPickerEndDate = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            btnCreate = new Button();
            btnClose = new Button();
            groupBox2 = new GroupBox();
            lblAccountBalance = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            comboBox1 = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(316, 9);
            label1.Name = "label1";
            label1.Size = new Size(154, 40);
            label1.TabIndex = 0;
            label1.Text = "New Loan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 524);
            label2.Name = "label2";
            label2.Size = new Size(100, 30);
            label2.TabIndex = 1;
            label2.Text = "Amount:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblMinAmount);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(lblMaxAmount);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(lblMonths);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lblMinBalance);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbLoanTypes);
            groupBox1.Location = new Point(12, 322);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(916, 171);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "..";
            // 
            // lblMinAmount
            // 
            lblMinAmount.AutoSize = true;
            lblMinAmount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMinAmount.Location = new Point(827, 44);
            lblMinAmount.Name = "lblMinAmount";
            lblMinAmount.Size = new Size(41, 21);
            lblMinAmount.TabIndex = 15;
            lblMinAmount.Text = "[???]";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(662, 44);
            label11.Name = "label11";
            label11.Size = new Size(110, 21);
            label11.TabIndex = 14;
            label11.Text = "Min Amount:";
            // 
            // lblMaxAmount
            // 
            lblMaxAmount.AutoSize = true;
            lblMaxAmount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaxAmount.Location = new Point(827, 112);
            lblMaxAmount.Name = "lblMaxAmount";
            lblMaxAmount.Size = new Size(41, 21);
            lblMaxAmount.TabIndex = 13;
            lblMaxAmount.Text = "[???]";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(662, 112);
            label9.Name = "label9";
            label9.Size = new Size(113, 21);
            label9.TabIndex = 12;
            label9.Text = "Max Amount:";
            // 
            // lblMonths
            // 
            lblMonths.AutoSize = true;
            lblMonths.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonths.Location = new Point(571, 44);
            lblMonths.Name = "lblMonths";
            lblMonths.Size = new Size(41, 21);
            lblMonths.TabIndex = 11;
            lblMonths.Text = "[???]";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(443, 44);
            label7.Name = "label7";
            label7.Size = new Size(115, 21);
            label7.TabIndex = 10;
            label7.Text = "Max Duration";
            // 
            // lblMinBalance
            // 
            lblMinBalance.AutoSize = true;
            lblMinBalance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMinBalance.Location = new Point(571, 112);
            lblMinBalance.Name = "lblMinBalance";
            lblMinBalance.Size = new Size(41, 21);
            lblMinBalance.TabIndex = 9;
            lblMinBalance.Text = "[???]";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(388, 112);
            label4.Name = "label4";
            label4.Size = new Size(153, 21);
            label4.TabIndex = 8;
            label4.Text = "Minimum Balance:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 30);
            label3.Name = "label3";
            label3.Size = new Size(119, 30);
            label3.TabIndex = 7;
            label3.Text = "Loan Type:";
            // 
            // cbLoanTypes
            // 
            cbLoanTypes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLoanTypes.Font = new Font("Segoe UI", 11F);
            cbLoanTypes.FormattingEnabled = true;
            cbLoanTypes.Location = new Point(162, 37);
            cbLoanTypes.Name = "cbLoanTypes";
            cbLoanTypes.Size = new Size(257, 28);
            cbLoanTypes.TabIndex = 6;
            cbLoanTypes.SelectedIndexChanged += cbLoanTypes_SelectedIndexChanged;
            // 
            // tbAmount
            // 
            tbAmount.Location = new Point(137, 533);
            tbAmount.Name = "tbAmount";
            tbAmount.Size = new Size(283, 23);
            tbAmount.TabIndex = 7;
            tbAmount.KeyPress += tbAmount_KeyPress;
            // 
            // dtPickerStartDate
            // 
            dtPickerStartDate.Font = new Font("Segoe UI", 12F);
            dtPickerStartDate.Format = DateTimePickerFormat.Short;
            dtPickerStartDate.Location = new Point(147, 611);
            dtPickerStartDate.Name = "dtPickerStartDate";
            dtPickerStartDate.Size = new Size(142, 29);
            dtPickerStartDate.TabIndex = 8;
            // 
            // dtPickerEndDate
            // 
            dtPickerEndDate.Font = new Font("Segoe UI", 12F);
            dtPickerEndDate.Format = DateTimePickerFormat.Short;
            dtPickerEndDate.Location = new Point(147, 685);
            dtPickerEndDate.Name = "dtPickerEndDate";
            dtPickerEndDate.Size = new Size(142, 29);
            dtPickerEndDate.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 610);
            label5.Name = "label5";
            label5.Size = new Size(117, 30);
            label5.TabIndex = 10;
            label5.Text = "Start Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 684);
            label6.Name = "label6";
            label6.Size = new Size(107, 30);
            label6.TabIndex = 11;
            label6.Text = "End Date:";
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI", 11F);
            btnCreate.Location = new Point(799, 805);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(129, 34);
            btnCreate.TabIndex = 12;
            btnCreate.Text = "CREATE";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 11F);
            btnClose.Location = new Point(664, 805);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(129, 34);
            btnClose.TabIndex = 14;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblAccountBalance);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Location = new Point(12, 108);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(916, 171);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "..";
            // 
            // lblAccountBalance
            // 
            lblAccountBalance.AutoSize = true;
            lblAccountBalance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccountBalance.Location = new Point(571, 44);
            lblAccountBalance.Name = "lblAccountBalance";
            lblAccountBalance.Size = new Size(41, 21);
            lblAccountBalance.TabIndex = 11;
            lblAccountBalance.Text = "[???]";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(443, 44);
            label15.Name = "label15";
            label15.Size = new Size(74, 21);
            label15.TabIndex = 10;
            label15.Text = "Balance:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.IndianRed;
            label16.Location = new Point(99, 112);
            label16.Name = "label16";
            label16.Size = new Size(549, 21);
            label16.TabIndex = 9;
            label16.Text = "- This Step Is Required To Approve That You Have The Minimum Balance - ";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(17, 112);
            label17.Name = "label17";
            label17.Size = new Size(52, 21);
            label17.TabIndex = 8;
            label17.Text = "Note:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(17, 30);
            label18.Name = "label18";
            label18.Size = new Size(101, 30);
            label18.TabIndex = 7;
            label18.Text = "Account:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 11F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(162, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(257, 28);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAddNewLoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 851);
            Controls.Add(groupBox2);
            Controls.Add(btnClose);
            Controls.Add(btnCreate);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dtPickerEndDate);
            Controls.Add(dtPickerStartDate);
            Controls.Add(tbAmount);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAddNewLoan";
            Text = "frmAddNewLoan";
            Load += frmAddNewLoan_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label lblMinAmount;
        private Label label11;
        private Label lblMaxAmount;
        private Label label9;
        private Label lblMonths;
        private Label label7;
        private Label lblMinBalance;
        private Label label4;
        private Label label3;
        private ComboBox cbLoanTypes;
        private TextBox tbAmount;
        private DateTimePicker dtPickerStartDate;
        private DateTimePicker dtPickerEndDate;
        private Label label5;
        private Label label6;
        private Button btnCreate;
        private Button btnClose;
        private GroupBox groupBox2;
        private Label lblAccountBalance;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private ComboBox comboBox1;
        private ErrorProvider errorProvider1;
    }
}