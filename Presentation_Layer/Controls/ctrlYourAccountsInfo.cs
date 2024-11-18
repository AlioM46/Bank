using Business_Layer;
using Presentation_Layer.Global_Classes;
using System.Data;

namespace Presentation_Layer.Controls
{
    public partial class ctrlYourAccountsInfo : UserControl
    {
        private DataTable _AccountsTable = new DataTable();
        private clsAccounts Account;
        private clsCurrencies Currency;
        private DataTable _CurrenciesTable = new DataTable();

        public ctrlYourAccountsInfo()
        {
            InitializeComponent();
        }

        private void _FillComboBox()
        {
            comboBox1.DisplayMember = "AccountNumber";
            comboBox1.DataSource = _AccountsTable;

            comboBox1.SelectedIndex = 0;
        }

        private void ctrlYourAccountsInfo_Load(object sender, EventArgs e)
        {
            _AccountsTable = clsAccounts.GetCustomersActiveAccounts(Global_Classes.clsGlobal.GlobalCustomer.CustomerID);


            if (_AccountsTable.Rows.Count == 0)
            {
                gb1.Controls.Clear();
                Label lbl = new Label();
                lbl.AutoSize = true;
                lbl.Text = "You Don't Have Active Accounts";
                lbl.Font = new System.Drawing.Font("Arial", 24, System.Drawing.FontStyle.Bold); // Set font size and style
                lbl.Location = new System.Drawing.Point(100, 40); // Offset for alignment with lb
                gb1.Controls.Add(lbl);



                return;
            }
            _FillCurrenciesComboBox();
            _FillComboBox();
        }



        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (comboBox1.Text.Length <= 0)
            {
                return;
            }


            //DataRow rowValue = _AccountsTable.Rows[comboBox1.SelectedIndex];

            Account = clsAccounts.FindByAccountNumber(comboBox1.Text);

            if (Account == null)
            {
                return;
            }

            lblCurrency.Text = Account.Currency.CurrencyName;
            lblBalance.Text = Account.Balance + " " + Account.Currency.CurrencySymbol;
            lblAccType.Text = Account.AccountTypes.AccountType;
            lblCreatedDate.Text = Account.CreatedDate.ToString();

            lblDeposit.Text = clsAccounts.GetTransactionsInPeriod(comboBox1.Text, 7, clsTransactions.enTransactions.Deposit).ToString("N2");
            lblWithdraw.Text = clsAccounts.GetTransactionsInPeriod(comboBox1.Text, 7, clsTransactions.enTransactions.Withdraw).ToString("N2");

            lblDeposit.Text += " USD";
            lblWithdraw.Text += " USD";

            for (int i = 0; i < _CurrenciesTable.Rows.Count; i++)
            {

                if (_CurrenciesTable.Rows[i]["CurrencyName"].ToString() == Account.Currency.CurrencyName)
                {
                    cbCurrencies.SelectedIndex = i;
                    break;
                }

            }
        }

        private void gb1_Enter(object sender, EventArgs e)
        {

        }

        private void _FillCurrenciesComboBox()
        {
            _CurrenciesTable = clsCurrencies.GetAllCurrencies();

            if (_CurrenciesTable.Rows.Count < 0 || _CurrenciesTable == null)
            {
                return;
            }
            cbCurrencies.DisplayMember = "CurrencyName";
            cbCurrencies.DataSource = _CurrenciesTable;




        }

        private void cbCurrencies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCurrencies.SelectedIndex < 0 || cbCurrencies.SelectedIndex >= _CurrenciesTable.Rows.Count)
            {
                return;
            }

            // Fetch the selected row from the data table
            DataRow selectedRow = _CurrenciesTable.Rows[cbCurrencies.SelectedIndex];



            // Use the selected currency name to find the corresponding currency
            string selectedCurrencyName = selectedRow["CurrencyName"].ToString();

            Currency = clsCurrencies.FindByCurrencyName(selectedCurrencyName);

            if (Currency == null)
            {
                MessageBox.Show("Selected currency could not be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are You Sure That You want to Change Your Account Currency To {Currency.CurrencyName}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            if (Account.CurrencyID == Currency.CurrencyID)
            {
                MessageBox.Show("You Can't Change To Same Account Currency", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal BalanceInDollar = (Account.Balance * Account.Currency.ExchangeRateToUSD);
            decimal NewBalanceInNewCurrency = (BalanceInDollar / Currency.ExchangeRateToUSD);
            Account.Balance = NewBalanceInNewCurrency;
            Account.CurrencyID = Currency.CurrencyID;

            if (!Account.Save())
            {
                MessageBox.Show("Error During Change Account Currency", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Currency Has Been Changed Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ctrlYourAccountsInfo_Load(null, null);

        }
    }
}
