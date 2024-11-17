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
    public partial class frmOpenAccountApplication : Form
    {


        private clsAccounts _Account = new clsAccounts();


        private DataTable _dtAccountTypes = new DataTable();
        private DataTable _dtCurrency = new DataTable();

        public enum enMode
        {
            AddNew = 1,
            Update = 2,
        }


        public enMode Mode;

        public frmOpenAccountApplication()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }


        private void _FillComboBox()
        {

            _dtAccountTypes = clsAccountTypes.GetAllAccountTypes();

            comboBox1.DisplayMember = "AccountType"; // Display currency names as strings
            comboBox1.ValueMember = "AccountTypeID";     // Set CurrencyID as the underlying value
            comboBox1.DataSource = _dtAccountTypes;

            comboBox1.SelectedIndex = 0;
        }


        private void _FillCurrenciesComboBox()
        {
            _dtCurrency = clsCurrencies.GetAllCurrencies();

            if (_dtCurrency.Rows.Count == 0)
            {
                MessageBox.Show("No currencies found in _dtCurrency.");
                return;
            }

            comboBox2.DisplayMember = "CurrencyName"; // Display currency names as strings
            comboBox2.ValueMember = "CurrencyID";     // Set CurrencyID as the underlying value
            comboBox2.DataSource = _dtCurrency;

            comboBox2.SelectedIndex = 0;
        }

        private void frmOpenAccountApplication_Load(object sender, EventArgs e)
        {
            _FillComboBox();
            _FillCurrenciesComboBox();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0 && comboBox1.SelectedIndex < _dtAccountTypes.Rows.Count)
            {
                // Get the selected row based on the combo box index
                DataRow selectedRow = _dtAccountTypes.Rows[comboBox1.SelectedIndex];

                // Update labels with values from the selected row
                lblFees.Text = selectedRow["Fees"].ToString(); // Replace Column1 with actual column name
                lblDescription.Text = selectedRow["Description"].ToString(); // Replace Column2 with actual column name
                                                                             // Add additional labels as needed
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool IsValid()
        {

            if (tbAccountNumber.Text.Length < 4)
            {
                errorProvider1.SetError(tbAccountNumber, "Enter Account Number & At Least 4 Chars");
                return false;
            }
            else if (!clsAccounts.IsValidAccountNumber(tbAccountNumber.Text.Trim()))
            {
                errorProvider1.SetError(tbAccountNumber, "This Account Number Is Already In Use, Choose Another One.");
                return false;
            }
            else
            {
                errorProvider1.SetError(tbAccountNumber, "");
            }


            return true;


        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (clsAccounts.DoesCustomerHaveAccountsOnPending(clsGlobal.GlobalCustomer.CustomerID))
            {
                // DO NOT ALLOW TO CREATE MORE THAN 1 Account while One or More ON PENDING.
                MessageBox.Show("You Can't Create An Account Right Now, Because You Already Have Account On Pending", "Blocked", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            if (Mode != enMode.AddNew)
            {
                MessageBox.Show("You Already Create Application to Open Account!");
                return;
            }
            if (!IsValid()) { return; }


            _Account.CustomerID = clsGlobal.GlobalCustomer.CustomerID;
            _Account.CurrencyID = (int)comboBox2.SelectedValue;
            _Account.Balance = 0m;
            if (_Account.AccountID == -1)
            {
                _Account.CreatedDate = DateTime.Now;
            }

            // 4 - Pending;
            _Account.Status = (int)clsAccounts.enAccountStatus.Pending;
            _Account.AccountTypeID = (int)comboBox1.SelectedValue;
            _Account.AccountNumber = tbAccountNumber.Text.Trim();

            if (!_Account.Save())
            {
                MessageBox.Show("Creating Account Is Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //

            clsApplications App = new clsApplications();

            App.ApplicationStatus = (int)clsApplications.enApplicationStatus.Pending;
            if (App.ApplicationID == -1)
            {
                App.ApplicationDate = DateTime.Now;
            }
            App.ApplicationDescription = "";
            App.CustomerID = clsGlobal.GlobalCustomer.CustomerID;
            App.ApplicationTypeID = (int)clsApplications.enApplicationType.Account;
            App.LastUpdateDate = DateTime.Now;
            App.AccountID = _Account.AccountID;

            if (App.Save())
            {
                Mode = enMode.Update;
                MessageBox.Show("Good Job, You Open Application To Create Account.", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //
                lblAccountID.Text = _Account.AccountID.ToString();
                lblBalance.Text = _Account.Balance.ToString();
                lblCreatedDate.Text = _Account.CreatedDate.ToString();
                lblStatus.Text = ((clsAccounts.enAccountStatus)_Account.Status).ToString();
                tbAccountNumber.Enabled = false;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                return;






            }
            else
            {
                MessageBox.Show("Creating Account Is Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }





        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
