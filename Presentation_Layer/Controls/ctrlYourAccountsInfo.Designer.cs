namespace Presentation_Layer.Controls
{
    partial class ctrlYourAccountsInfo
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
            gb1 = new GroupBox();
            label6 = new Label();
            cbCurrencies = new ComboBox();
            button1 = new Button();
            lblWithdraw = new Label();
            lblDeposit = new Label();
            label8 = new Label();
            label9 = new Label();
            lblCreatedDate = new Label();
            lblCurrency = new Label();
            lblAccType = new Label();
            lblBalance = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            gb1.SuspendLayout();
            SuspendLayout();
            // 
            // gb1
            // 
            gb1.Controls.Add(label6);
            gb1.Controls.Add(cbCurrencies);
            gb1.Controls.Add(button1);
            gb1.Controls.Add(lblWithdraw);
            gb1.Controls.Add(lblDeposit);
            gb1.Controls.Add(label8);
            gb1.Controls.Add(label9);
            gb1.Controls.Add(lblCreatedDate);
            gb1.Controls.Add(lblCurrency);
            gb1.Controls.Add(lblAccType);
            gb1.Controls.Add(lblBalance);
            gb1.Controls.Add(label5);
            gb1.Controls.Add(label4);
            gb1.Controls.Add(label3);
            gb1.Controls.Add(label2);
            gb1.Controls.Add(label1);
            gb1.Controls.Add(comboBox1);
            gb1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gb1.Location = new Point(3, 3);
            gb1.Name = "gb1";
            gb1.Size = new Size(948, 409);
            gb1.TabIndex = 2;
            gb1.TabStop = false;
            gb1.Text = "Your Accounts Info:";
            gb1.Enter += gb1_Enter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.IndianRed;
            label6.Location = new Point(609, 81);
            label6.Name = "label6";
            label6.Size = new Size(333, 21);
            label6.TabIndex = 18;
            label6.Text = "*This Will Change Your Account Currency.*";
            // 
            // cbCurrencies
            // 
            cbCurrencies.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCurrencies.FormattingEnabled = true;
            cbCurrencies.Location = new Point(763, 27);
            cbCurrencies.Name = "cbCurrencies";
            cbCurrencies.Size = new Size(179, 29);
            cbCurrencies.TabIndex = 17;
            cbCurrencies.SelectedIndexChanged += cbCurrencies_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button1.Location = new Point(804, 353);
            button1.Name = "button1";
            button1.Size = new Size(138, 50);
            button1.TabIndex = 16;
            button1.Text = "CONFIRM";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblWithdraw
            // 
            lblWithdraw.AutoSize = true;
            lblWithdraw.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWithdraw.Location = new Point(282, 149);
            lblWithdraw.Name = "lblWithdraw";
            lblWithdraw.Size = new Size(41, 21);
            lblWithdraw.TabIndex = 15;
            lblWithdraw.Text = "[???]";
            // 
            // lblDeposit
            // 
            lblDeposit.AutoSize = true;
            lblDeposit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeposit.Location = new Point(282, 99);
            lblDeposit.Name = "lblDeposit";
            lblDeposit.Size = new Size(41, 21);
            lblDeposit.TabIndex = 14;
            lblDeposit.Text = "[???]";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(28, 149);
            label8.Name = "label8";
            label8.Size = new Size(141, 21);
            label8.TabIndex = 13;
            label8.Text = "Weekly Withdraw:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(28, 99);
            label9.Name = "label9";
            label9.Size = new Size(128, 21);
            label9.TabIndex = 12;
            label9.Text = "Weekly Deposit:";
            // 
            // lblCreatedDate
            // 
            lblCreatedDate.AutoSize = true;
            lblCreatedDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreatedDate.Location = new Point(282, 353);
            lblCreatedDate.Name = "lblCreatedDate";
            lblCreatedDate.Size = new Size(41, 21);
            lblCreatedDate.TabIndex = 11;
            lblCreatedDate.Text = "[???]";
            // 
            // lblCurrency
            // 
            lblCurrency.AutoSize = true;
            lblCurrency.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrency.Location = new Point(282, 303);
            lblCurrency.Name = "lblCurrency";
            lblCurrency.Size = new Size(41, 21);
            lblCurrency.TabIndex = 10;
            lblCurrency.Text = "[???]";
            // 
            // lblAccType
            // 
            lblAccType.AutoSize = true;
            lblAccType.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccType.Location = new Point(282, 253);
            lblAccType.Name = "lblAccType";
            lblAccType.Size = new Size(41, 21);
            lblAccType.TabIndex = 9;
            lblAccType.Text = "[???]";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalance.Location = new Point(282, 203);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(41, 21);
            lblBalance.TabIndex = 8;
            lblBalance.Text = "[???]";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(28, 353);
            label5.Name = "label5";
            label5.Size = new Size(92, 21);
            label5.TabIndex = 7;
            label5.Text = "Open Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 303);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 6;
            label4.Text = "Currency:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 253);
            label3.Name = "label3";
            label3.Size = new Size(114, 21);
            label3.TabIndex = 5;
            label3.Text = "Account Type:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 203);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 4;
            label2.Text = "Balance:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 39);
            label1.Name = "label1";
            label1.Size = new Size(134, 21);
            label1.TabIndex = 3;
            label1.Text = "Choose Account:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(159, 41);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(171, 29);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // ctrlYourAccountsInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gb1);
            Name = "ctrlYourAccountsInfo";
            Size = new Size(954, 415);
            Load += ctrlYourAccountsInfo_Load;
            gb1.ResumeLayout(false);
            gb1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb1;
        private Label label1;
        private ComboBox comboBox1;
        private Label lblCreatedDate;
        private Label lblCurrency;
        private Label lblAccType;
        private Label lblBalance;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblWithdraw;
        private Label lblDeposit;
        private Label label8;
        private Label label9;
        private Button button1;
        private Label label6;
        private ComboBox cbCurrencies;
    }
}
