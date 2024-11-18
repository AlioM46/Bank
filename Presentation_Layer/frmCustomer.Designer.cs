namespace Presentation_Layer
{
    partial class frmCustomer
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
            menuStrip1 = new MenuStrip();
            ManageAccountsToolStrip = new ToolStripMenuItem();
            myAccountsListToolStripMenuItem = new ToolStripMenuItem();
            addNewAccountToolStripMenuItem = new ToolStripMenuItem();
            ManageLoansToolStrip = new ToolStripMenuItem();
            manageMyLoansToolStripMenuItem = new ToolStripMenuItem();
            newLoanToolStripMenuItem = new ToolStripMenuItem();
            RequestSupportToolStrip = new ToolStripMenuItem();
            ManageTransactionsToolStrip = new ToolStripMenuItem();
            ChangeInformationToolStrip = new ToolStripMenuItem();
            ctrlDateTime1 = new Controls.ctrlDateTime();
            ctrlTopCustomersBalances1 = new Controls.ctrlTopCustomersBalances();
            ctrlYourAccountsInfo1 = new Controls.ctrlYourAccountsInfo();
            ctrlTotalBalances1 = new Controls.ctrlTotalBalances();
            btnDownload = new Button();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.GripMargin = new Padding(2);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ManageAccountsToolStrip, ManageLoansToolStrip, RequestSupportToolStrip, ManageTransactionsToolStrip, ChangeInformationToolStrip });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1904, 37);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // ManageAccountsToolStrip
            // 
            ManageAccountsToolStrip.DropDownItems.AddRange(new ToolStripItem[] { myAccountsListToolStripMenuItem, addNewAccountToolStripMenuItem });
            ManageAccountsToolStrip.Name = "ManageAccountsToolStrip";
            ManageAccountsToolStrip.Size = new Size(142, 33);
            ManageAccountsToolStrip.Text = "Accounts";
            ManageAccountsToolStrip.Click += ManageAccountsToolStrip_Click;
            // 
            // myAccountsListToolStripMenuItem
            // 
            myAccountsListToolStripMenuItem.Name = "myAccountsListToolStripMenuItem";
            myAccountsListToolStripMenuItem.Size = new Size(355, 34);
            myAccountsListToolStripMenuItem.Text = "Manage My Accounts";
            myAccountsListToolStripMenuItem.Click += myAccountsListToolStripMenuItem_Click;
            // 
            // addNewAccountToolStripMenuItem
            // 
            addNewAccountToolStripMenuItem.Name = "addNewAccountToolStripMenuItem";
            addNewAccountToolStripMenuItem.Size = new Size(355, 34);
            addNewAccountToolStripMenuItem.Text = "Add New Account";
            addNewAccountToolStripMenuItem.Click += addNewAccountToolStripMenuItem_Click;
            // 
            // ManageLoansToolStrip
            // 
            ManageLoansToolStrip.DropDownItems.AddRange(new ToolStripItem[] { manageMyLoansToolStripMenuItem, newLoanToolStripMenuItem });
            ManageLoansToolStrip.Name = "ManageLoansToolStrip";
            ManageLoansToolStrip.Size = new Size(100, 33);
            ManageLoansToolStrip.Text = "Loans";
            ManageLoansToolStrip.Click += ManageLoansToolStrip_Click;
            // 
            // manageMyLoansToolStripMenuItem
            // 
            manageMyLoansToolStripMenuItem.Name = "manageMyLoansToolStripMenuItem";
            manageMyLoansToolStripMenuItem.Size = new Size(313, 34);
            manageMyLoansToolStripMenuItem.Text = "Manage My Loans";
            manageMyLoansToolStripMenuItem.Click += manageMyLoansToolStripMenuItem_Click;
            // 
            // newLoanToolStripMenuItem
            // 
            newLoanToolStripMenuItem.Name = "newLoanToolStripMenuItem";
            newLoanToolStripMenuItem.Size = new Size(313, 34);
            newLoanToolStripMenuItem.Text = "New Loan";
            newLoanToolStripMenuItem.Click += newLoanToolStripMenuItem_Click;
            // 
            // RequestSupportToolStrip
            // 
            RequestSupportToolStrip.Name = "RequestSupportToolStrip";
            RequestSupportToolStrip.Size = new Size(127, 33);
            RequestSupportToolStrip.Text = "Support";
            RequestSupportToolStrip.Click += RequestSupportToolStrip_Click;
            // 
            // ManageTransactionsToolStrip
            // 
            ManageTransactionsToolStrip.Name = "ManageTransactionsToolStrip";
            ManageTransactionsToolStrip.Size = new Size(189, 33);
            ManageTransactionsToolStrip.Text = "Transactions";
            ManageTransactionsToolStrip.Click += ManageTransactionsToolStrip_Click;
            // 
            // ChangeInformationToolStrip
            // 
            ChangeInformationToolStrip.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Bold);
            ChangeInformationToolStrip.Name = "ChangeInformationToolStrip";
            ChangeInformationToolStrip.Size = new Size(281, 33);
            ChangeInformationToolStrip.Text = "Change Information";
            ChangeInformationToolStrip.Click += ChangeInformationToolStrip_Click;
            // 
            // ctrlDateTime1
            // 
            ctrlDateTime1.Location = new Point(897, 598);
            ctrlDateTime1.Name = "ctrlDateTime1";
            ctrlDateTime1.Size = new Size(419, 317);
            ctrlDateTime1.TabIndex = 2;
            // 
            // ctrlTopCustomersBalances1
            // 
            ctrlTopCustomersBalances1.Location = new Point(12, 96);
            ctrlTopCustomersBalances1.Name = "ctrlTopCustomersBalances1";
            ctrlTopCustomersBalances1.Size = new Size(778, 461);
            ctrlTopCustomersBalances1.TabIndex = 3;
            // 
            // ctrlYourAccountsInfo1
            // 
            ctrlYourAccountsInfo1.Location = new Point(850, 140);
            ctrlYourAccountsInfo1.Name = "ctrlYourAccountsInfo1";
            ctrlYourAccountsInfo1.Size = new Size(961, 417);
            ctrlYourAccountsInfo1.TabIndex = 4;
            // 
            // ctrlTotalBalances1
            // 
            ctrlTotalBalances1.Location = new Point(20, 574);
            ctrlTotalBalances1.Name = "ctrlTotalBalances1";
            ctrlTotalBalances1.Size = new Size(857, 300);
            ctrlTotalBalances1.TabIndex = 5;
            // 
            // btnDownload
            // 
            btnDownload.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDownload.Location = new Point(20, 921);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(289, 69);
            btnDownload.TabIndex = 6;
            btnDownload.Text = "Download Last 7 Days Report Download as PDF";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(897, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 67);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // frmCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(pictureBox1);
            Controls.Add(btnDownload);
            Controls.Add(ctrlTotalBalances1);
            Controls.Add(ctrlYourAccountsInfo1);
            Controls.Add(ctrlTopCustomersBalances1);
            Controls.Add(ctrlDateTime1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F);
            Name = "frmCustomer";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Customer Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += frmCustomer_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ManageAccountsToolStrip;
        private ToolStripMenuItem ManageLoansToolStrip;
        private ToolStripMenuItem RequestSupportToolStrip;
        private ToolStripMenuItem ManageTransactionsToolStrip;
        private ToolStripMenuItem ChangeInformationToolStrip;
        private ToolStripMenuItem myAccountsListToolStripMenuItem;
        private ToolStripMenuItem addNewAccountToolStripMenuItem;
        private ToolStripMenuItem manageMyLoansToolStripMenuItem;
        private ToolStripMenuItem newLoanToolStripMenuItem;
        private Controls.ctrlDateTime ctrlDateTime1;
        private Controls.ctrlTopCustomersBalances ctrlTopCustomersBalances1;
        private Controls.ctrlYourAccountsInfo ctrlYourAccountsInfo1;
        private Controls.ctrlTotalBalances ctrlTotalBalances1;
        private Button btnDownload;
        private PictureBox pictureBox1;
    }
}