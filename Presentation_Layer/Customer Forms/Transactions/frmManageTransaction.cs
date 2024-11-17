using Business_Layer;
using Microsoft.VisualBasic.Logging;
using Presentation_Layer.Customer_Forms.Loans;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.Customer_Forms.Transactions
{
    public partial class frmManageTransaction : Form
    {

        public enum enPayMode
        {
            Deposit = 1, Withdraw = 2, Transfer = 3
        }


        public decimal AmountInUSD = -1;
        public decimal AmountInAccountCurrency = -1;




        private decimal ExchangeRateToUSD = -1;
        private decimal _Amount = -1;
        DataTable dtCurrency = new DataTable();

        private enPayMode _Mode;
        private enPayMode Mode
        {

            get { return _Mode; }
            set
            {
                _Mode = value;
                switch (value)
                {
                    case enPayMode.Deposit:
                        btnDeposet.BackColor = Color.Red;
                        btnTransfer.BackColor = Color.White;
                        btnWithdraw.BackColor = Color.White;
                        lblTitle.Text = "Enter The Amount To Deposit:";
                        ctrlAnotherPersonAccount.Visible = false;
                        break;
                    case enPayMode.Withdraw:
                        btnDeposet.BackColor = Color.White;
                        btnTransfer.BackColor = Color.White;
                        btnWithdraw.BackColor = Color.Red;
                        lblTitle.Text = "Enter The Amount To Withdraw:";
                        ctrlAnotherPersonAccount.Visible = false;


                        break;
                    case enPayMode.Transfer:
                        btnDeposet.BackColor = Color.White;
                        btnTransfer.BackColor = Color.Red;
                        btnWithdraw.BackColor = Color.White;
                        lblTitle.Text = "Enter The Amount To Transfer Between Two Accounts:";
                        ctrlAnotherPersonAccount.Visible = true;

                        break;



                }
            }

        }
        public frmManageTransaction()
        {
            InitializeComponent();
        }


        private void btnLoanPaymentClick(object sender, EventArgs e)
        {
            // 
            frmLoansManagement frm = new frmLoansManagement();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void frmManageTransaction_Load(object sender, EventArgs e)
        {
            Mode = enPayMode.Deposit;
            _FilLCurrenciesComboBox();
        }

        private void btnTransferClick(object sender, EventArgs e)
        {
            Mode = enPayMode.Transfer;
        }

        private void btnWithdrawClick(object sender, EventArgs e)
        {
            Mode = enPayMode.Withdraw;
        }


        private void btnDepositClick(object sender, EventArgs e)
        {
            Mode = enPayMode.Deposit;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && tbAmount.Text.Contains('.'))
            {
                e.Handled = true;
            }

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }


        private bool IsValid()
        {
            if (tbAmount.Text.Trim().Length == 0)
            {
                return false;
            }
            return true;

        }

        public void HandleDeposit()
        {



            if (!ctrlYouAccount.AccountInfo.Deposit(AmountInAccountCurrency, Global_Classes.clsGlobal.GlobalCustomer.CustomerID, clsTransactions.enTransactions.Deposit))
            {
                MessageBox.Show("Failed With Deposit Operation", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            ctrlYouAccount.LoadInfo(ctrlYouAccount.AccountNumber);
            tbAmount.Text = "";
            MessageBox.Show("Deposit Has Been Done Successfully", "DOne", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
        public void HandleWithdraw()
        {
            // From Any Currency TO USD = EURO-Money * ExchangeRate
            // From USD TO Any Currency = USD-Money / ExchangeRate

            // You Need to Put In Your Mind That if You want to Deposit as Euro:
            // Then: take the Amount Multiply it By ExchangeRateToUSD, Then Devide it By ExchangeRate Of Your Currency
            // 100 EUR -> *1.1 = 110 USD -> SAR = USD / .266
            // Simply.
            // Same as Withdraw and Transfer.

            //AmountInUSD = _Amount * ExchangeRateToUSD;
            //AmountInAccountCurrency = (_Amount * ExchangeRateToUSD) / ctrlYouAccount.AccountInfo.Currency.ExchangeRateToUSD;


            if (AmountInUSD > ctrlYouAccount.AccountMaximumBalance)
            {
                MessageBox.Show($"You Can't Withdraw More Than {ctrlYouAccount.AccountMaximumBalance.ToString("N2")} USD or {ctrlYouAccount.AccountInfo.Balance.ToString("N2")} {ctrlYouAccount.AccountInfo.Currency.CurrencyName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ctrlYouAccount.AccountInfo.Withdraw(AmountInAccountCurrency, Global_Classes.clsGlobal.GlobalCustomer.CustomerID, clsTransactions.enTransactions.Withdraw))
            {
                MessageBox.Show($"Failed To Withdraw Your Money", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Successfully Withdraw {AmountInAccountCurrency.ToString("N2")} {ctrlYouAccount.AccountInfo.Currency.CurrencyName}\nYour New Balance Is {ctrlYouAccount.AccountInfo.Balance.ToString("N2")} {ctrlYouAccount.AccountInfo.Currency.CurrencyName}", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ctrlYouAccount.LoadInfo(ctrlYouAccount.AccountNumber);
            tbAmount.Text = "";



        }
        public void HandleTransfer()
        {
            if (ctrlAnotherPersonAccount.AccountInfo == null)
            {
                MessageBox.Show("This Account Is Required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (AmountInUSD > ctrlYouAccount.AccountMaximumBalance)
            {
                MessageBox.Show($"You Can't Withdraw More Than {ctrlYouAccount.AccountMaximumBalance.ToString("N2")} USD or {ctrlYouAccount.AccountInfo.Balance.ToString("N2")} {ctrlYouAccount.AccountInfo.Currency.CurrencyName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ctrlYouAccount.AccountInfo.Transfer(AmountInUSD, ctrlAnotherPersonAccount.AccountInfo.AccountNumber))
            {
                MessageBox.Show("Transfer Is Field", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Transfer Is Done Successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ctrlYouAccount.LoadInfo(ctrlYouAccount.AccountNumber);
            tbAmount.Text = "";


        }

        private void btndoit_Click(object sender, EventArgs e)
        {



            if (ctrlYouAccount.AccountInfo == null)
            {
                MessageBox.Show("Search For Your Account First.");
                return;
            }
            if (!IsValid())
            {
                MessageBox.Show("Fill Amount Field");
                return;
            }
            _Amount = Convert.ToDecimal(tbAmount.Text);

            AmountInUSD = _Amount * ExchangeRateToUSD;
            AmountInAccountCurrency = (_Amount * ExchangeRateToUSD) / ctrlYouAccount.AccountInfo.Currency.ExchangeRateToUSD;


            // Make Sure To Handle Currencies in ;



            if (Mode == enPayMode.Deposit)
            {
                HandleDeposit();
                return;
            }
            if (Mode == enPayMode.Withdraw)
            {
                HandleWithdraw();
                return;
            }
            if (Mode == enPayMode.Transfer)
            {
                HandleTransfer();
                return;
            }






        }

        private void ctrlShowAccountInfo1_Load(object sender, EventArgs e)
        {

        }

        private void _FilLCurrenciesComboBox()
        {
            dtCurrency = clsCurrencies.GetAllCurrencies();

            cbCurrencies.DisplayMember = "CurrencyName";
            cbCurrencies.DataSource = dtCurrency;

        }

        private void cbCurrencies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCurrencies.SelectedIndex >= 0 && cbCurrencies.SelectedIndex < dtCurrency.Rows.Count)
            {
                DataRow RowValue = dtCurrency.Rows[cbCurrencies.SelectedIndex];
                ExchangeRateToUSD = Convert.ToDecimal(RowValue["ExchangeRateToUSD"]);

            }
        }

        private void ctrlYouAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
