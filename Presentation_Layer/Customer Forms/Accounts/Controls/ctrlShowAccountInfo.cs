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

namespace Presentation_Layer.Customer_Forms.Accounts.Controls
{
    public partial class ctrlShowAccountInfo : UserControl
    {


        private bool _IsMyAccount = true;
        public bool IsMyAccount
        {
            get
            {
                return _IsMyAccount;

            }
            set
            {
                _IsMyAccount = value;
                lblBalance.Visible = value;
                label2.Visible = value;

            }
        }








        private bool _EnableFilter = true;
        public string AccountNumber = "";


        private decimal _AccountMaximumBalance = -1;
        public decimal AccountMaximumBalance
        {
            get { return _AccountMaximumBalance; }
            set
            {
                _AccountMaximumBalance = value;

                if (_EnableFilter)
                {
                    // Because It's Replace the [???] with -1;
                    return;
                }
                lblBalance.Text = value.ToString();

            }
        }

        public clsAccounts AccountInfo;

        public bool EnableFilter
        {
            get
            {
                return _EnableFilter;

            }
            set
            {
                _EnableFilter = value;
                panel1.Enabled = value;
            }
        }
        public ctrlShowAccountInfo()
        {
            InitializeComponent();
        }


        public void LoadInfo(string AccountNumber)
        {

            textBox1.Text = AccountNumber;
            this.AccountNumber = AccountNumber;
            AccountInfo = clsAccounts.FindByAccountNumber(textBox1.Text.Trim());

            if (AccountInfo != null)
            {
                if (AccountInfo.Status != (int)clsAccounts.enAccountStatus.Active)
                {
                    MessageBox.Show("This Account Is Active Yet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (IsMyAccount)
                {

                    if (AccountInfo.CustomerID != clsGlobal.GlobalCustomer.CustomerID)
                    {
                        MessageBox.Show("This Account Is Not For You!", "Not For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                AccountMaximumBalance = AccountInfo.Balance * AccountInfo.Currency.ExchangeRateToUSD;
                AccountNumber = AccountInfo.AccountNumber;



                lblBalance.Text = AccountMaximumBalance.ToString();
                lblCurrency.Text = "USD";
                EnableFilter = false;



            }
            else
            {
                MessageBox.Show("Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                errorProvider1.SetError(textBox1, "Required!");
                return;
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
            }

            LoadInfo(textBox1.Text.Trim());

        }

        private void ctrlShowAccountInfo_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
