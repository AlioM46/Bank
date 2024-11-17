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

namespace Presentation_Layer.User_Forms
{
    public partial class frmManageApplications : Form
    {

        private string FilterName = "";

        private DataTable _dt = new DataTable();
        private DataView _dv = new DataView();

        private clsApplications App;


        private void _RefreshApplicationsRecords()
        {
            _dt = clsApplications.GetAllApplications();
            if (_dt.Rows.Count > 0)
            {
                _dv = _dt.DefaultView;
                dgvAllApplications.DataSource = _dv;


                dgvAllApplications.Columns[0].HeaderText = "Application ID";
                dgvAllApplications.Columns[1].HeaderText = "Customer ID";
                dgvAllApplications.Columns[2].HeaderText = "Customer Name";
                dgvAllApplications.Columns[3].HeaderText = "Application Type";
                dgvAllApplications.Columns[4].HeaderText = "Application Date";
                dgvAllApplications.Columns[5].HeaderText = "Status";
                dgvAllApplications.Columns[6].HeaderText = "Description";

                foreach (DataGridViewColumn column in dgvAllApplications.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            lblRecords.Text = _dt.Rows.Count.ToString();

        }

        public frmManageApplications()
        {
            InitializeComponent();
        }

        private void frmManageApplications_Load(object sender, EventArgs e)
        {
            _RefreshApplicationsRecords();
        }
        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilters.Text == "None")
            {
                _dv.RowFilter = ""; // Clear any existing filters
            }
            else if (cbFilters.Text == "Accounts")
            {
                _dv.RowFilter = "ApplicationType = 'Account'"; // Enclose the value in single quotes
            }
            else if (cbFilters.Text == "Loans")
            {
                _dv.RowFilter = "ApplicationType = 'Loan'"; // Enclose the value in single quotes
            }


        }

        private void ApplyFilters()
        {

            string Filtering = "";

            if (!string.IsNullOrWhiteSpace(cbFilters.Text) && cbFilters.Text != "None")
            {
                if (cbFilters.Text == "Accounts")
                {
                    Filtering = "ApplicationType = 'Account'";
                }
                else if (cbFilters.Text == "Loans")
                {
                    Filtering = "ApplicationType = 'Loan'";

                }
            }


            // Combine Two Filters.

            if (!string.IsNullOrWhiteSpace(tbFilter.Text) && !string.IsNullOrWhiteSpace(FilterName))
            {
                if (FilterName == "CustomerID" || FilterName == "ApplicationID")
                {
                    Filtering += $" And {FilterName} = '{tbFilter.Text.Trim()}'";
                }
                else
                {
                    Filtering += $" And {FilterName} LIKE '%{tbFilter.Text.Trim()}%'";
                }
            }

            _dv.RowFilter = Filtering;


        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }



        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (FilterName == "CustomerID" || FilterName == "ApplicationID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }


        private void cbSecondFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilter.Text = "";
            if (cbSecondFilter.Text == "None")
            {
                tbFilter.Enabled = false;
            }
            else
            {
                tbFilter.Enabled = true;
            }


            switch (cbSecondFilter.Text)
            {

                case "Customer ID":
                    FilterName = "CustomerID";
                    break;
                case "Application ID":
                    FilterName = "ApplicationID";
                    break;
                case "Customer Name":
                    FilterName = "CustomerName";
                    break;
                case "Status":
                    FilterName = "Status";
                    break;

                default:
                    break;

            }

        }

        private void provideDocumentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string FileName = "";
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    FileName = openFileDialog.FileName;
                }
            }

        }



        private void HandleLoanApprove()
        {
            clsLoans Loan = clsLoans.FindLoanByApplicationID(App.ApplicationID);


            if (App.Save() &&  Loan.Approve(clsGlobal.GlobalCustomer.CustomerID))
            {

                // also reject the loan in loans record.
                MessageBox.Show("Application Has Been Approved Successfully.", "Approved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshApplicationsRecords();
                return;
            }
            MessageBox.Show("Failed To Update The Application", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



        private void HandleAccountApprove()
        {
            //clsAccounts Account = clsAccounts.FindByApplicationID(App.ApplicationID);


            if (App.Save() && App.Accounts.Approve())
            {

                // also reject the loan in loans record.
                MessageBox.Show("Application Has Been Approved Successfully.", "Approved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshApplicationsRecords();
                return;
            }
            MessageBox.Show("Failed To Update The Application", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void approveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            App.ApplicationStatus = (int)clsApplications.enApplicationStatus.Approved;


            if (App.ApplicationTypeID == (int)clsApplicationTypes.enApplicationTypes.Loan)
            {
                HandleLoanApprove();
            }
            else if (App.ApplicationTypeID == (int)clsApplicationTypes.enApplicationTypes.OpenAccount)
            {
                HandleAccountApprove();
            }
        }

        private void HandleAccountReject()
        {

            if (App.Save() && App.Accounts.Reject())
            {

                // also reject the loan in loans record.
                MessageBox.Show("Application Has Been Rejected Successfully.", "Rejected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshApplicationsRecords();
                return;
            }
            MessageBox.Show("Failed To Update The Application", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void HandleLoanReject()
        {
            clsLoans Loan = clsLoans.FindLoanByApplicationID(App.ApplicationID);

            if (App.Save() && Loan.Reject())
            {

                // also reject the loan in loans record.
                MessageBox.Show("Application Has Been Rejected Successfully.", "Rejected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshApplicationsRecords();
                return;
            }
            MessageBox.Show("Failed To Update The Application", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void rejectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            App.ApplicationStatus = (int)clsApplications.enApplicationStatus.Rejected;

            if (App.ApplicationTypeID == (int)clsApplicationTypes.enApplicationTypes.Loan)
            {
                HandleLoanReject();
            }
            else if (App.ApplicationTypeID == (int)clsApplicationTypes.enApplicationTypes.OpenAccount)
            {
                HandleAccountReject();
            }
        }


        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

            int AppID = (int)dgvAllApplications.CurrentRow.Cells[0].Value;
            App = clsApplications.Find(AppID);

            if (App == null)
            {
                MessageBox.Show("Application is Missed", "Missed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (App.ApplicationStatus == (int)clsApplications.enApplicationStatus.Rejected || App.ApplicationStatus == (int)clsApplications.enApplicationStatus.Cancelled || App.ApplicationStatus == (int)clsApplications.enApplicationStatus.Approved)
            {
                payFeesToolStripMenuItem.Enabled = false;
                rejectToolStripMenuItem.Enabled = false;
                approveToolStripMenuItem.Enabled = false;
                provideDocumentsToolStripMenuItem.Enabled = false;
                return;

            }



            // [1] : check for (is Free For First Time) -> (Do You Already Have an Account) ? (Do You Have Paid For This Application?) ? Disable Pay Button :Enable Pay Button   : Enable Pay Button 

            if (App.ApplicationTypes.FreeForFirstTime)
            {

                if (App.ApplicationTypeID == 1)
                {


                    if (clsAccounts.DoesCustomerHaveActiveAccount(clsGlobal.GlobalCustomer.CustomerID))
                    {
                        // This means that there's Payment ( Have Paid )



                        payFeesToolStripMenuItem.Enabled = true;
                        rejectToolStripMenuItem.Enabled = true;
                        approveToolStripMenuItem.Enabled = false;

                    }
                    else
                    {
                        payFeesToolStripMenuItem.Enabled = false;
                    }


                }
                // END
            }
            else
            {
                payFeesToolStripMenuItem.Enabled = true;
                rejectToolStripMenuItem.Enabled = true;
                approveToolStripMenuItem.Enabled = false;

            }


            provideDocumentsToolStripMenuItem.Enabled = App.ApplicationTypes.RequiresDocuments;

            if (clsPayments.FindPaymentByApplicationID(App.ApplicationID) != null)
            {
                payFeesToolStripMenuItem.Enabled = false;
                rejectToolStripMenuItem.Enabled = true;
                approveToolStripMenuItem.Enabled = true;
            }

        }

        private void payFeesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show($"Are You Sure To Pay {App.ApplicationTypes.ApplicationFees.ToString()}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;



            clsPayments AppPayment = new clsPayments();


            if (!AppPayment.CreatePayment(App))
            {
                MessageBox.Show("Failed To Pay", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("You Have Paid Successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshApplicationsRecords();
            }

        }
    }
}
