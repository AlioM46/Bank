using Business_Layer;
using DataAccess_Layer;
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

namespace Presentation_Layer.Customer_Forms.Loans
{
    public partial class frmAddNewLoan : Form
    {

        private int _LoanTypeID = -1;
        private int _MonthsDuration = -1;


        private string _AccountNumber = "";
        private decimal _AccountBalance = -1;
        public frmAddNewLoan()
        {
            InitializeComponent();
        }
        public DataTable _dt = new DataTable();
        public DataTable _dtAccounts = new DataTable();
        private Business_Layer.clsLoans Loan = new Business_Layer.clsLoans();

        public enum enMode { AddNew = 1, Update = 2 }
        private enMode Mode = enMode.AddNew;

        private void _FillComboBoxLoanTypes()
        {
            _dt = Business_Layer.clsLoanTypes.GetAllLoanTypes();


            cbLoanTypes.DisplayMember = "LoanType";
            cbLoanTypes.DataSource = _dt;

        }
        private void _FillComboBoxAccounts()
        {
            _dtAccounts = Business_Layer.clsAccounts.GetCustomersActiveAccounts(clsGlobal.GlobalCustomer.CustomerID);


            comboBox1.DisplayMember = "AccountNumber";
            comboBox1.DataSource = _dtAccounts;


        }

        private void frmAddNewLoan_Load(object sender, EventArgs e)
        {
            _FillComboBoxLoanTypes();
            _FillComboBoxAccounts();


            dtPickerStartDate.Enabled = false;

            dtPickerStartDate.Value = DateTime.Now;


            dtPickerEndDate.MinDate = DateTime.Now.AddDays(1);
            dtPickerEndDate.MaxDate = DateTime.Now.AddMonths(_MonthsDuration);


            dtPickerEndDate.Value = DateTime.Now.AddDays(1);
        }

        private void cbLoanTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoanTypes.SelectedIndex >= 0 && cbLoanTypes.SelectedIndex < _dt.Rows.Count)
            {
                DataRow RowValue = _dt.Rows[cbLoanTypes.SelectedIndex];
                _LoanTypeID = Convert.ToInt32(RowValue["LoanTypeID"]);
                _MonthsDuration = Convert.ToInt32(RowValue["MaxMonthsDuration"]);
                lblMonths.Text = _MonthsDuration.ToString() + " Month's";
                lblMinBalance.Text = "$" + RowValue["MinimumBalance"].ToString();
                lblMinAmount.Text = "$" + RowValue["MinAmount"].ToString();
                lblMaxAmount.Text = "$" + RowValue["MaxAmount"].ToString();


                // TO Set the New Max Date.
                dtPickerEndDate.MaxDate = DateTime.Now.AddMonths(_MonthsDuration);
                dtPickerEndDate.Value = DateTime.Now.AddDays(1);
            }
        }

        private bool IsValid()
        {
            if (tbAmount.Text.Trim().Length == 0) {
                errorProvider1.SetError(tbAmount, "Required");
                return false;
            } else
            {
                errorProvider1.SetError(tbAmount, "");
                return true;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            if (Mode == enMode.Update)
            {
                MessageBox.Show("You Already Create Loan Application!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Business_Layer.clsLoanTypes LoanType = Business_Layer.clsLoanTypes.Find(_LoanTypeID);


            if (!IsValid())
            {
                return;
            }
             decimal Amount = Convert.ToDecimal(tbAmount.Text.Trim());

            if (_AccountBalance < LoanType.MinimumBalance)
            {
                MessageBox.Show("Your Balance Is Not Enough!", "You Need More Money!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Amount > LoanType.MaxAmount)
            {
                MessageBox.Show($"The Maximum Amount Is {LoanType.MaxAmount}", "You Need to Low Your Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Amount < LoanType.MinAmount)
            {
                MessageBox.Show($"The Minimum Amount Is {LoanType.MinAmount}", "You Need to Up Your Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Check The Conditions, Amount, Date, Balance.

            if (MessageBox.Show("Are You Sure To Create Loan Application?", "Confirmation?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;



            Business_Layer.clsAccounts TempAccount = Business_Layer.clsAccounts.FindByAccountNumber(_AccountNumber);

            // Create App.

            Business_Layer.clsApplications App = new Business_Layer.clsApplications();
            App.ApplicationStatus = (int)Business_Layer.clsApplications.enApplicationStatus.Pending;
            App.AccountID = TempAccount.AccountID;
            App.ApplicationTypeID = (int)Business_Layer.clsApplicationTypes.enApplicationTypes.Loan;
            App.ApplicationDate = DateTime.Now;
            App.LastUpdateDate = DateTime.Now;
            App.CustomerID = clsGlobal.GlobalCustomer.CustomerID;

            if (App.Save())
            {

                Loan.ApplicationID = App.ApplicationID;
                Loan.Status = (int)Business_Layer.clsLoans.enLoanStatus.Pending;
                Loan.StartDate = dtPickerStartDate.Value;
                Loan.EndDate = dtPickerEndDate.Value;
                Loan.AllPayments = 0;
                Loan.Amount = Amount;
                Loan.LastUpdateDate = DateTime.Now;
                Loan.LoanTypeID = _LoanTypeID;
                if (Loan.Save())
                {
                    MessageBox.Show("Your Loan Application Has Been Submit Successfully.", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mode = enMode.Update;
                } else
                {
                    App.ApplicationStatus = (int)Business_Layer.clsApplications.enApplicationStatus.Cancelled;
                    App.Save();
                    btnCreate.Enabled = false;
                    MessageBox.Show("Failed To Create Loan.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Close?", "Confirmation?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;

            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0 && comboBox1.SelectedIndex < _dtAccounts.Rows.Count)
            {
                DataRow RowValue = _dtAccounts.Rows[comboBox1.SelectedIndex];


                _AccountNumber = RowValue["AccountNumber"].ToString();
                _AccountBalance = Convert.ToDecimal(RowValue["Dollar"]);
                lblAccountBalance.Text = "$" + _AccountBalance.ToString();
                //

            }
        }

        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
