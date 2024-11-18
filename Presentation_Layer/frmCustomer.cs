using Presentation_Layer.Customer_Forms;
using Presentation_Layer.Customer_Forms.Accounts;
using Presentation_Layer.Customer_Forms.Loans;
using Presentation_Layer.Customer_Forms.Transactions;
using Presentation_Layer.Global_Classes;
using Presentation_Layer.User_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }


        public void HandleForms(Form frm)
        {
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }



        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {

            pictureBox1.ImageLocation = Global_Classes.clsGlobal.GlobalCustomer.People.ImagePath;

            // Make the PictureBox circular
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Width = 100;  // Set width (make sure height is the same for a square)
            pictureBox1.Height = 100; // Set height (same as width for a square)

            ctrlTopCustomersBalances1.DisplayTop5Balances();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void ManageAccountsToolStrip_Click(object sender, EventArgs e)
        {
            HandleForms(new Presentation_Layer.Customer_Forms.Accounts.frmManageAccounts());

        }

        private void ManageLoansToolStrip_Click(object sender, EventArgs e)
        {
            HandleForms(new frmLoansManagement());

        }

        private void RequestSupportToolStrip_Click(object sender, EventArgs e)
        {
            HandleForms(new frmSupport());

        }

        private void ManageTransactionsToolStrip_Click(object sender, EventArgs e)
        {
            HandleForms(new frmManageTransaction());
        }

        private void ChangeInformationToolStrip_Click(object sender, EventArgs e)
        {
            HandleForms(new frmChangeInformation(false));

        }

        private void myAccountsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_Forms.Accounts.frmManageAccounts frm = new Customer_Forms.Accounts.frmManageAccounts();
            HandleForms(frm);
        }

        private void addNewAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOpenAccountApplication frm = new frmOpenAccountApplication();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void manageMyLoansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoansManagement frm = new frmLoansManagement();
            HandleForms(frm);

        }

        private void newLoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewLoan frm = new frmAddNewLoan();
            HandleForms(frm);
        }

        

        private void btnDownload_Click(object sender, EventArgs e)
        {
            clsGlobal.ExportTransactionsAsPDF();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Logout", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;

            this.Close();
            clsGlobal.GlobalCustomer = null;
        }
    }
}
