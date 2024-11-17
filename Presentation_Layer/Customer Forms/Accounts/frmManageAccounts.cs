using Business_Layer;
using Presentation_Layer.Global_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.Customer_Forms.Accounts
{
    public partial class frmManageAccounts : Form
    {


        private DataTable _dt = new DataTable();
        public frmManageAccounts()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmOpenAccountApplication frm = new frmOpenAccountApplication();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            _RefreshDataGrid();
        }

        private void _RefreshDataGrid()
        {

            _dt = clsCustomers.GetAllAccounts(clsGlobal.GlobalCustomer.CustomerID);

            if (_dt.Rows.Count > 0)
            {
                dgvAllAccounts.DataSource = _dt;
                lblRecords.Text = _dt.Rows.Count.ToString();


                dgvAllAccounts.Columns[0].HeaderText = "Account ID";
                dgvAllAccounts.Columns[1].HeaderText = "Customer ID";
                dgvAllAccounts.Columns[2].HeaderText = "Account Number";
                dgvAllAccounts.Columns[3].HeaderText = "Account Type";
                dgvAllAccounts.Columns[4].HeaderText = "Balance";
                dgvAllAccounts.Columns[5].HeaderText = "Account Currency";
                dgvAllAccounts.Columns[6].HeaderText = "Created Date";
                dgvAllAccounts.Columns[7].HeaderText = "Status";

                foreach (DataGridViewColumn column in dgvAllAccounts.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }



            }
        }
        private void frmManageAccounts_Load(object sender, EventArgs e)
        {
            _RefreshDataGrid();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Delete this Account?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int AccountID = (int)dgvAllAccounts.CurrentRow.Cells[0].Value;

            clsAccounts TempAccount = clsAccounts.Find(AccountID);


            if (TempAccount != null)
            {
                if (TempAccount.Status == (int)clsAccounts.enAccountStatus.Closed)
                {
                    MessageBox.Show("Account Already Marked As Delete..", "Done", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }


            if (clsAccounts.Delete(AccountID))
            {
                if (clsApplications.DeleteApplicationByAccountNumber(AccountID))
                {
                    MessageBox.Show("Account Marked As Deleted Successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _RefreshDataGrid();
                }

            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void showInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowAccountInfo frm = new frmShowAccountInfo(dgvAllAccounts.CurrentRow.Cells[2].Value.ToString());
            this.Hide();
            frm.ShowDialog();   
            this.Show();
        }
    }
}
