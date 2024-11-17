namespace Presentation_Layer.Customer_Forms.Transactions
{
    partial class frmManageTransaction
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
            btnWithdraw = new Button();
            btnTransfer = new Button();
            btnLoan = new Button();
            btnDeposet = new Button();
            lblTitle = new Label();
            tbAmount = new TextBox();
            ctrlYouAccount = new Accounts.Controls.ctrlShowAccountInfo();
            btndoit = new Button();
            ctrlAnotherPersonAccount = new Accounts.Controls.ctrlShowAccountInfo();
            cbCurrencies = new ComboBox();
            SuspendLayout();
            // 
            // btnWithdraw
            // 
            btnWithdraw.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            btnWithdraw.Location = new Point(365, 262);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(277, 88);
            btnWithdraw.TabIndex = 1;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdrawClick;
            // 
            // btnTransfer
            // 
            btnTransfer.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            btnTransfer.Location = new Point(702, 262);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(277, 88);
            btnTransfer.TabIndex = 2;
            btnTransfer.Text = "Transfer";
            btnTransfer.UseVisualStyleBackColor = true;
            btnTransfer.Click += btnTransferClick;
            // 
            // btnLoan
            // 
            btnLoan.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            btnLoan.Location = new Point(1039, 262);
            btnLoan.Name = "btnLoan";
            btnLoan.Size = new Size(277, 88);
            btnLoan.TabIndex = 3;
            btnLoan.Text = "Loan Paymnet";
            btnLoan.UseVisualStyleBackColor = true;
            btnLoan.Click += btnLoanPaymentClick;
            // 
            // btnDeposet
            // 
            btnDeposet.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            btnDeposet.Location = new Point(28, 262);
            btnDeposet.Name = "btnDeposet";
            btnDeposet.Size = new Size(277, 88);
            btnDeposet.TabIndex = 4;
            btnDeposet.Text = "Deposit";
            btnDeposet.UseVisualStyleBackColor = true;
            btnDeposet.Click += btnDepositClick;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Sakkal Majalla", 24F);
            lblTitle.Location = new Point(42, 422);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(230, 42);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Enter The Amount To ";
            // 
            // tbAmount
            // 
            tbAmount.Font = new Font("Segoe UI", 12F);
            tbAmount.Location = new Point(699, 428);
            tbAmount.Name = "tbAmount";
            tbAmount.Size = new Size(390, 29);
            tbAmount.TabIndex = 6;
            tbAmount.TextChanged += textBox1_TextChanged;
            tbAmount.KeyPress += textBox1_KeyPress;
            // 
            // ctrlYouAccount
            // 
            ctrlYouAccount.AccountMaximumBalance = new decimal(new int[] { 1, 0, 0, int.MinValue });
            ctrlYouAccount.EnableFilter = true;
            ctrlYouAccount.IsMyAccount = true;
            ctrlYouAccount.Location = new Point(39, 12);
            ctrlYouAccount.Name = "ctrlYouAccount";
            ctrlYouAccount.Size = new Size(607, 244);
            ctrlYouAccount.TabIndex = 7;
            ctrlYouAccount.Load += ctrlYouAccount_Load;
            // 
            // btndoit
            // 
            btndoit.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            btndoit.Location = new Point(1162, 525);
            btndoit.Name = "btndoit";
            btndoit.Size = new Size(198, 57);
            btndoit.TabIndex = 8;
            btndoit.Text = "DO IT";
            btndoit.UseVisualStyleBackColor = true;
            btndoit.Click += btndoit_Click;
            // 
            // ctrlAnotherPersonAccount
            // 
            ctrlAnotherPersonAccount.AccountMaximumBalance = new decimal(new int[] { 1, 0, 0, int.MinValue });
            ctrlAnotherPersonAccount.EnableFilter = true;
            ctrlAnotherPersonAccount.IsMyAccount = false;
            ctrlAnotherPersonAccount.Location = new Point(699, 12);
            ctrlAnotherPersonAccount.Name = "ctrlAnotherPersonAccount";
            ctrlAnotherPersonAccount.Size = new Size(669, 244);
            ctrlAnotherPersonAccount.TabIndex = 9;
            ctrlAnotherPersonAccount.Load += ctrlShowAccountInfo1_Load;
            // 
            // cbCurrencies
            // 
            cbCurrencies.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCurrencies.FormattingEnabled = true;
            cbCurrencies.Location = new Point(42, 375);
            cbCurrencies.Name = "cbCurrencies";
            cbCurrencies.Size = new Size(230, 23);
            cbCurrencies.TabIndex = 10;
            cbCurrencies.SelectedIndexChanged += cbCurrencies_SelectedIndexChanged;
            // 
            // frmManageTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1372, 594);
            Controls.Add(cbCurrencies);
            Controls.Add(ctrlAnotherPersonAccount);
            Controls.Add(btndoit);
            Controls.Add(ctrlYouAccount);
            Controls.Add(tbAmount);
            Controls.Add(lblTitle);
            Controls.Add(btnDeposet);
            Controls.Add(btnLoan);
            Controls.Add(btnTransfer);
            Controls.Add(btnWithdraw);
            Name = "frmManageTransaction";
            Text = "frmTransaction";
            Load += frmManageTransaction_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        //private Button btnDeposit;
        private Button btnWithdraw;
        private Button btnTransfer;
        private Button btnLoan;
        private Button btnDeposet;
        private Label lblTitle;
        private TextBox tbAmount;
        private Accounts.Controls.ctrlShowAccountInfo ctrlYouAccount;
        private Button btndoit;
        private Accounts.Controls.ctrlShowAccountInfo ctrlAnotherPersonAccount;
        private ComboBox cbCurrencies;
    }
}