using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.Controls
{
    public partial class ctrlYourAccountsInfo : UserControl
    {
        private DataTable _AccountsTable = new DataTable();
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
            _FillComboBox();
        }



        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataRow rowValue = _AccountsTable.Rows[comboBox1.SelectedIndex];

            lblBalance.Text = rowValue["Balance"].ToString();
            lblAccType.Text = rowValue["AccountType"].ToString();
            lblCreatedDate.Text = rowValue["CreatedDate"].ToString();
            lblCurrency.Text = rowValue["CurrencyName"].ToString();

            lblDeposit.Text = clsAccounts.GetTransactionsInPeriod(rowValue["AccountNumber"].ToString(), 7, clsTransactions.enTransactions.Deposit).ToString("N2");
            lblWithdraw.Text = clsAccounts.GetTransactionsInPeriod(rowValue["AccountNumber"].ToString(), 7, clsTransactions.enTransactions.Withdraw).ToString("N2");


        }
    }
}
