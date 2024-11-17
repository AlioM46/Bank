using Business_Layer;
using Microsoft.IdentityModel.Tokens;
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
    public partial class frmLoanPayment : Form
    {
        public frmLoanPayment()
        {
            InitializeComponent();
        }
        private int _LoanID = -1;
        private decimal _Amount = -1;


        private clsLoans Loan;
      private  decimal LoanReminder ;

        public frmLoanPayment(int LoanID)
        {
            InitializeComponent();
            _LoanID = LoanID;


        }

        private bool IsValidAmount()
        {

            if (tbAmount.Text.Trim().Length == 0)
            {
                return false;
            }
            _Amount = Convert.ToDecimal(tbAmount.Text.Trim());

            if (_Amount > ctrlShowAccountInfo1.AccountMaximumBalance || _Amount <= 0)
            {
                return false;
            }


            return true;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

            if (ctrlShowAccountInfo1.AccountMaximumBalance <= 0)
            {
                MessageBox.Show("No Balance", "No Money Available", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (Loan.AllPayments == Loan.Amount || Loan.AllPayments> Loan.Amount)
            {
                MessageBox.Show("Your Loan Are Fully Paid", "No Worries", MessageBoxButtons.OK, MessageBoxIcon.Information );
                return;
            }

            if (ctrlShowAccountInfo1.AccountNumber == "")
            {
                MessageBox.Show("Search For Your Account Number First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidAmount())
            {
                MessageBox.Show("Amount Cannot Be More Than " + ctrlShowAccountInfo1.AccountMaximumBalance.ToString("N2") + " and Less Than 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Are You Sure To Withdraw ${_Amount.ToString("N2")} from Your Account?", "Confirmation?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;


            // 1 - Add Money To Loan Payment


            // 2 - Make Sure That is The Money You Want To Pay is Not Bigger than The Loan Amount



            if (_Amount >= LoanReminder)
            {

                if (MessageBox.Show($"Are You Sure To Pay All The Loan ${LoanReminder.ToString("N2")}? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;
                
                _Amount = LoanReminder;
            }

            Loan.LastUpdateDate = DateTime.Now;
            Loan.AllPayments += _Amount;

            if(Loan.AllPayments == Loan.Amount)
            {
                Loan.Status = (int)clsLoans.enLoanStatus.Fulfilled;
                btnPay.Enabled = false;
                tbAmount.Enabled = false;
            }

            if (!Loan.Save())
            {
                MessageBox.Show("Error During Save Loan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Withdraw Money From the Account -> Make Sure To Exchange The Currency Well.


            clsAccounts Account = clsAccounts.FindByAccountNumber(ctrlShowAccountInfo1.AccountNumber);

            if (Account == null)
            {
                MessageBox.Show("Could Not Find The Loan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal convertedAmount = _Amount / Account.Currency.ExchangeRateToUSD;

            if (!Account.Withdraw(Math.Round(convertedAmount, 3), clsGlobal.GlobalCustomer.CustomerID, clsTransactions.enTransactions.LoanPayment))
            {
                MessageBox.Show("Error During Save Withdraw from Your Account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            tbAmount.Text = "";
            ctrlShowAccountInfo1.AccountMaximumBalance = Math.Round(Account.Balance * Account.Currency.ExchangeRateToUSD, 3);
            SetLoanLabels();
            //if (!Account.Save())
            //{
            //    MessageBox.Show("Error During Save Account New Balance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            // if ACC WITHDRWA USD -> / 1
            // if ACC WITHDRWA SAR -> / 0.266





        }

        private void frmLoanPayment_Load(object sender, EventArgs e)
        {
            Loan = clsLoans.Find(_LoanID);
            if (Loan == null)
            {
                MessageBox.Show("Could Not Find The Loan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SetLoanLabels();


        }

        private void SetLoanLabels()
        {

            LoanReminder = Loan.Amount - Loan.AllPayments;

            lblLoanPayments.Text = "$" + Loan.AllPayments.ToString("N3");
            lblReminder.Text = "$" + LoanReminder.ToString("N3");
            lblPercentage.Text = ((Loan.AllPayments / Loan.Amount) * 100).ToString("N3") + "%";
        }

        private void tbAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void ctrlShowAccountInfo1_Load(object sender, EventArgs e)
        {

        }

        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == '.')
            {
                // Check if the TextBox already contains a decimal point
                if (tbAmount.Text.Contains("."))
                {
                    e.Handled = true; // Block input if a decimal point already exists
                }
                return; // Allow this character if it's the first decimal point
            }

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) ;
        }
    }
}
