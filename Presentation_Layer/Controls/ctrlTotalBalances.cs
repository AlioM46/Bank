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

namespace Presentation_Layer.Controls
{
    public partial class ctrlTotalBalances : UserControl
    {

        public double balance = 0;
        public double BalanceInUSD = 0;
        private DataTable _currencies = new DataTable();
        public ctrlTotalBalances()
        {
            InitializeComponent();
        }


        public void LoadInfo()
        {

        }


        private void _FillCurrenciesComboBox()
        {
            _currencies = clsCurrencies.GetAllCurrencies();

            cbCurrencies.DisplayMember = "CurrencyName";
            cbCurrencies.DataSource = _currencies;



        }


        private void ctrlTotalBalances_Load(object sender, EventArgs e)
        {

            _FillCurrenciesComboBox();

            balance = clsCustomers.GetAllAccountsBalanceInDollar(Global_Classes.clsGlobal.GlobalCustomer.CustomerID);
            BalanceInUSD = balance;

            // BalanceInUSD is Constant, but Balance is Changable.
            int YourRank = Global_Classes.clsGlobal.GlobalCustomer.YourBalanceRank();

            if (YourRank > 0)
            {
                lblRank.Text = "#" + YourRank.ToString();
            }
            else
            {
                lblRank.Text = "Not Detectable yet!";
            }

            if (balance > 0)
            {
                lblTotal.Text = 
                lblTotal.Text = (balance).ToString("N3");

            }




        }

        private void gb1_Enter(object sender, EventArgs e)
        {

        }

        private void cbCurrencies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCurrencies.SelectedIndex >= 0 && cbCurrencies.SelectedIndex < _currencies.Rows.Count)
            {
                // becuase it's entered one by one.
                DataRow rowValue = _currencies.Rows[cbCurrencies.SelectedIndex];

                //string currencyName = rowValue["CurrencyName"].ToString();
                //string currencyID = rowValue["CurrencyID"].ToString();
                double ExchangeRate = Convert.ToDouble(rowValue["ExchangeRateToUSD"]);
                //MessageBox.Show(currencyID);
                //MessageBox.Show(currencyName);
                //MessageBox.Show(ExchangeRate.ToString());

                lblTotal.Text = (BalanceInUSD / ExchangeRate).ToString("N3");


            }
        }
    }
}
