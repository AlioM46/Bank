using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class clsCurrencies
    {

        public int CurrencyID { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencySymbol { get; set; }
        public decimal ExchangeRateToUSD { get; set; }

        public clsCurrencies(int CurrencyID, string CurrencyName, string CurrencySymbol, decimal ExchangeRateToUSD)
        {
            this.CurrencyID = CurrencyID;
            this.CurrencyName = CurrencyName;
            this.CurrencySymbol = CurrencySymbol;
            this.ExchangeRateToUSD = ExchangeRateToUSD;

        }
        public static DataTable GetAllCurrencies()
        {
            return DataAccess_Layer.clsCurrencies.GetAllCurrencies();

        }
        public static clsCurrencies Find(int CurrencyID)
        {

            string currencyName = "";
            string currencySymbol = "";
            decimal exchangeRateToUSD = -1;

            if (DataAccess_Layer.clsCurrencies.Find(CurrencyID, ref currencyName, ref currencySymbol, ref exchangeRateToUSD))
            {
                return new clsCurrencies(CurrencyID, currencyName, currencySymbol, exchangeRateToUSD);
            }
            else
            {
                return null;
            }

        }

        public static clsCurrencies FindByCurrencyName(string CurrencyName)
        {

            string currencySymbol = "";
            decimal exchangeRateToUSD = -1;
            int CurrencyID = -1;

            if (DataAccess_Layer.clsCurrencies.FindByCurrencyName(ref CurrencyID, CurrencyName, ref currencySymbol, ref exchangeRateToUSD))
            {
                return new clsCurrencies(CurrencyID, CurrencyName, currencySymbol, exchangeRateToUSD);
            }
            else
            {
                return null;
            }

        }

    }
}
