namespace Presentation_Layer.Customer_Forms.Loans
{
    partial class frmLoanPayment
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
            ctrlShowAccountInfo1 = new Accounts.Controls.ctrlShowAccountInfo();
            tbAmount = new TextBox();
            label1 = new Label();
            btnPay = new Button();
            label2 = new Label();
            lblLoanPayments = new Label();
            lblReminder = new Label();
            label4 = new Label();
            lblPercentage = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // ctrlShowAccountInfo1
            // 
            ctrlShowAccountInfo1.AccountMaximumBalance = new decimal(new int[] { 1, 0, 0, int.MinValue });
            ctrlShowAccountInfo1.EnableFilter = true;
            ctrlShowAccountInfo1.Location = new Point(3, 2);
            ctrlShowAccountInfo1.Name = "ctrlShowAccountInfo1";
            ctrlShowAccountInfo1.Size = new Size(830, 230);
            ctrlShowAccountInfo1.TabIndex = 0;
            ctrlShowAccountInfo1.Load += ctrlShowAccountInfo1_Load;
            // 
            // tbAmount
            // 
            tbAmount.Location = new Point(211, 264);
            tbAmount.Name = "tbAmount";
            tbAmount.Size = new Size(273, 23);
            tbAmount.TabIndex = 1;
            tbAmount.TextChanged += tbAmount_TextChanged;
            tbAmount.KeyPress += tbAmount_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 259);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 2;
            label1.Text = "Amount (USD):";
            // 
            // btnPay
            // 
            btnPay.Font = new Font("Segoe UI", 16F);
            btnPay.Location = new Point(734, 415);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(99, 47);
            btnPay.TabIndex = 3;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 336);
            label2.Name = "label2";
            label2.Size = new Size(152, 25);
            label2.TabIndex = 4;
            label2.Text = "Loan Payments:";
            // 
            // lblLoanPayments
            // 
            lblLoanPayments.AutoSize = true;
            lblLoanPayments.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoanPayments.Location = new Point(211, 340);
            lblLoanPayments.Name = "lblLoanPayments";
            lblLoanPayments.Size = new Size(43, 21);
            lblLoanPayments.TabIndex = 5;
            lblLoanPayments.Text = "[???]";
            // 
            // lblReminder
            // 
            lblReminder.AutoSize = true;
            lblReminder.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReminder.Location = new Point(211, 392);
            lblReminder.Name = "lblReminder";
            lblReminder.Size = new Size(43, 21);
            lblReminder.TabIndex = 7;
            lblReminder.Text = "[???]";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 388);
            label4.Name = "label4";
            label4.Size = new Size(153, 25);
            label4.TabIndex = 6;
            label4.Text = "Loan Reminder:";
            // 
            // lblPercentage
            // 
            lblPercentage.AutoSize = true;
            lblPercentage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPercentage.Location = new Point(632, 336);
            lblPercentage.Name = "lblPercentage";
            lblPercentage.Size = new Size(43, 21);
            lblPercentage.TabIndex = 9;
            lblPercentage.Text = "[???]";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(409, 336);
            label5.Name = "label5";
            label5.Size = new Size(199, 25);
            label5.TabIndex = 8;
            label5.Text = "Payment Percentage:";
            // 
            // frmLoanPayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 465);
            Controls.Add(lblPercentage);
            Controls.Add(label5);
            Controls.Add(lblReminder);
            Controls.Add(label4);
            Controls.Add(lblLoanPayments);
            Controls.Add(label2);
            Controls.Add(btnPay);
            Controls.Add(label1);
            Controls.Add(tbAmount);
            Controls.Add(ctrlShowAccountInfo1);
            Name = "frmLoanPayment";
            Text = "frmLoanPayment";
            Load += frmLoanPayment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Accounts.Controls.ctrlShowAccountInfo ctrlShowAccountInfo1;
        private TextBox tbAmount;
        private Label label1;
        private Button btnPay;
        private Label label2;
        private Label lblLoanPayments;
        private Label lblReminder;
        private Label label4;
        private Label lblPercentage;
        private Label label5;
    }
}