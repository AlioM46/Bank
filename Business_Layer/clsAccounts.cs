using System;
using DataAccess_Layer;
using System.Data;
using System.Reflection.Metadata.Ecma335;

namespace Business_Layer
{
    public class clsAccounts
    {



        public enum enMode { AddNew = 1, Update = 2 };
        public enMode Mode { get; set; }

        public int AccountID { get; set; }
        public int CustomerID { get; set; }
        public int AccountTypeID { get; set; }
        public decimal Balance { get; set; }
        public string AccountNumber { get; set; }
        public int CurrencyID { get; set; }

        public int Status { get; set; }
        public DateTime CreatedDate { get; set; }

        public enum enAccountStatus
        {
            Active = 1, Frozen = 2, Closed = 3, Pending = 4, Rejected = 5
        }

        public clsCurrencies Currency { get; set; }
        public clsCustomers Customers { get; set; }
        public clsAccountTypes AccountTypes { get; set; }

        public decimal AmountInUSD { get { return this.Balance * this.Currency.ExchangeRateToUSD; } private set { } }

        public clsAccounts(int AccountID, int CustomerID, int AccountTypeID, decimal Balance, string AccountNumber, int CurrencyID, int Status, DateTime CreatedDate)
        {

            this.AccountID = AccountID;
            this.CustomerID = CustomerID;


            this.AccountTypeID = AccountTypeID;


            this.Balance = Balance;
            this.AccountNumber = AccountNumber;
            this.CurrencyID = CurrencyID;
            this.Status = Status;
            this.CreatedDate = CreatedDate;
            Mode = enMode.Update;

            Currency = clsCurrencies.Find(CurrencyID);
            AccountTypes = clsAccountTypes.Find(AccountTypeID);
            Customers = clsCustomers.Find(CustomerID);

        }

        public clsAccounts()
        {

            this.AccountID = -1;
            this.CustomerID = -1;
            this.AccountTypeID = -1;
            this.Balance = -1;
            this.AccountNumber = "";
            this.CurrencyID = -1;
            this.Status = -1;
            this.CreatedDate = DateTime.MaxValue;
            Mode = enMode.AddNew;

        }

        private bool _AddNewAccounts()
        {

            this.AccountID = DataAccess_Layer.clsAccounts.AddNewAccounts(this.CustomerID, this.AccountTypeID, (this.Balance + 500), this.AccountNumber, this.CurrencyID, this.Status, this.CreatedDate);

            return this.AccountID != -1;
        }

        private bool _UpdateAccounts()
        {

            return DataAccess_Layer.clsAccounts.UpdateAccounts(this.AccountID, this.CustomerID, this.AccountTypeID, this.Balance, this.AccountNumber, this.CurrencyID, this.Status, this.CreatedDate);
        }

        public static bool Delete(int AccountID)
        {

            return DataAccess_Layer.clsAccounts.DeleteAccounts(AccountID);
        }

        public bool Delete()
        {

            return DataAccess_Layer.clsAccounts.DeleteAccounts(this.AccountID);
        }

        public static clsAccounts FindByAccountNumber(string AccountNumber)
        {

            int CustomerID = -1;
            int AccountTypeID = -1;
            decimal Balance = -1;
            int AccountID = -1;
            int CurrencyID = -1;
            int Status = -1;

            DateTime CreatedDate = new DateTime();
            CreatedDate = DateTime.MaxValue;


            if (DataAccess_Layer.clsAccounts.FindByAccountNumber(ref AccountID, ref CustomerID, ref AccountTypeID, ref Balance, AccountNumber, ref CurrencyID, ref Status, ref CreatedDate))
            {

                return new clsAccounts(AccountID, CustomerID, AccountTypeID, Balance, AccountNumber, CurrencyID, Status, CreatedDate);
            }
            else
            {
                return null;
            }
        }

        public static clsAccounts Find(int AccountID)
        {

            int CustomerID = -1;
            int AccountTypeID = -1;
            decimal Balance = -1;
            string AccountNumber = "";
            int CurrencyID = -1;
            int Status = -1;

            DateTime CreatedDate = new DateTime();
            CreatedDate = DateTime.MaxValue;


            if (DataAccess_Layer.clsAccounts.Find(AccountID, ref CustomerID, ref AccountTypeID, ref Balance, ref AccountNumber, ref CurrencyID, ref Status, ref CreatedDate))
            {

                return new clsAccounts(AccountID, CustomerID, AccountTypeID, Balance, AccountNumber, CurrencyID, Status, CreatedDate);
            }
            else
            {
                return null;
            }
        }



        public static clsAccounts FindByApplicationID(int ApplicationID)
        {
            int AccountID = -1;
            int CustomerID = -1;
            int AccountTypeID = -1;
            decimal Balance = -1;
            string AccountNumber = "";
            int CurrencyID = -1;
            int Status = -1;
            // Here.
            DateTime CreatedDate = new DateTime();


            if (DataAccess_Layer.clsAccounts.FindByApplicationID(ApplicationID, ref AccountID, ref CustomerID, ref AccountTypeID, ref Balance, ref AccountNumber, ref CurrencyID, ref Status, ref CreatedDate))
            {

                return new clsAccounts(AccountID, CustomerID, AccountTypeID, Balance, AccountNumber, CurrencyID, Status, CreatedDate);
            }
            else
            {
                return null;
            }
        }


        public bool Save()
        {



            switch (Mode)
            {
                case enMode.Update:
                    return _UpdateAccounts();

                case enMode.AddNew:

                    if (_AddNewAccounts())
                    {
                        Mode = enMode.Update;
                        return true;

                    }
                    else
                    {
                        return false;
                    }
                default: return false;

            }
        }

        public static bool DoesAccountsExists(int AccountID)
        {
            return DataAccess_Layer.clsAccounts.DoesAccountsExists(AccountID);
        }

        public static bool IsValidAccountNumber(string AccountNumber)
        {
            return DataAccess_Layer.clsAccounts.IsValidAccountNumber(AccountNumber);
        }


        public bool DoesAccountsExists()
        {
            return DoesAccountsExists(this.AccountID);
        }

        public static DataTable GetAllAccounts()
        {
            return DataAccess_Layer.clsAccounts.GetAllAccounts();
        }


        // -- This is Used on DataGridView Accounts Management -- // 
        public static DataTable GetAllAccountsForCustomer(int CustomerID)
        {
            return DataAccess_Layer.clsAccounts.GetAllAccountsForCustomer(CustomerID);
        }


        // This is Used In The Main Customers Form ( Customer Accounts Info ) // 
        public static DataTable GetCustomersActiveAccounts(int CustomerID)
        {
            return DataAccess_Layer.clsAccounts.GetCustomersActiveAccounts(CustomerID);
        }


        public static decimal GetTransactionsInPeriod(string AccountNumber, int Days, clsTransactions.enTransactions TransactionMode)
        {
            return DataAccess_Layer.clsAccounts.GetTransactionsInPeriod(AccountNumber, Days, (int)TransactionMode);
        }


        public bool Withdraw(decimal Amount, int CustomerID, clsTransactions.enTransactions TransactionType = clsTransactions.enTransactions.Withdraw)
        {


            if (Amount > this.Balance || Amount < 0)
            {
                return false;
            }

            // Create Transaction Record.

            this.Balance -= Amount;
            if (!Save())
            {
                return false;
            }



            clsTransactions Transaction = new clsTransactions();

            decimal AmountInUSD = (Amount * this.Currency.ExchangeRateToUSD);

            if (!Transaction.CreateTransaction(AmountInUSD, this.AccountID, TransactionType, CustomerID))
            {
                return false;
            }

            return true;


        }


        public bool Withdraw(decimal Amount)
        {
            if (Amount > this.Balance || Amount < 0)
            {
                return false;
            }

            // Create Transaction Record.

            this.Balance -= Amount;
            if (!Save())
            {
                return false;
            }

            return true;


        }


        public bool Deposit(decimal AmountInAccountCurrency, int CustomerID, clsTransactions.enTransactions TransactionType = clsTransactions.enTransactions.Deposit)
        {

            if (AmountInAccountCurrency < 0)
            {
                return false;
            }

            // Create Transaction Record.

            this.Balance += AmountInAccountCurrency;
            if (!Save())
            {
                return false;
            }



            clsTransactions Transaction = new clsTransactions();

            decimal AmountInUSD = (AmountInAccountCurrency * this.Currency.ExchangeRateToUSD);
            if (!Transaction.CreateTransaction(AmountInUSD, this.AccountID, TransactionType, CustomerID))
            {
                return false;
            }

            return true;


        }


        public bool Transfer(decimal AmountInUSD, string AccountNumber)
        {
            clsAccounts TransferToAccount = clsAccounts.FindByAccountNumber(AccountNumber);
            if (TransferToAccount == null)
            {
                return false;
            }

            if (this.AmountInUSD < AmountInUSD)
            {
                return false;
            }


            TransferToAccount.Balance += (AmountInUSD / TransferToAccount.Currency.ExchangeRateToUSD);
            this.Balance -= (AmountInUSD / this.Currency.ExchangeRateToUSD);


            clsTransactions Transaction = new clsTransactions();

            if (!Transaction.CreateTransaction(AmountInUSD, this.AccountID, clsTransactions.enTransactions.Transfer, CustomerID))
            {
                return false;
            }

            if (!TransferToAccount.Save() || !Save())
            {
                return false;
            }

            return true;
        }


        public bool Approve()
        {
            this.Status = (int)clsAccounts.enAccountStatus.Active;
            return this.Save();
        }
        public bool Reject()
        {
            this.Status = (int)clsAccounts.enAccountStatus.Rejected;
            return this.Save();
        }



        public static bool DoesCustomerHaveActiveAccount(int CustomerID)
        {
            // I use this Function on (Applications Context Menu) To Know if it's first time or not
            return DataAccess_Layer.clsAccounts.DoesCustomerHaveActiveAccount(CustomerID);
        }

        public static bool DoesCustomerHaveAccountsOnPending(int CustomerID)
        {
            // I use this Function on (Applications Context Menu) To Know if it's first time or not
            return DataAccess_Layer.clsAccounts.DoesCustomerHaveAccountsOnPending(CustomerID);
        }


        public bool CanWithdraw(int DaysPeriod, decimal AmountInDollar)
        {

            if (AmountInDollar <= 0)
            {
                return false;
            }

            decimal DailyWithdraw = clsAccounts.GetTransactionsInPeriod(this.AccountNumber, DaysPeriod, clsTransactions.enTransactions.Withdraw);

            // Note: This Function Above, return Transactions Amounts In (Dollar)($)

            return ((AmountInDollar + DailyWithdraw) < this.AccountTypes.WithdrawDailyLimit);
        }


        public bool CanDeposit(int DaysPeriod, decimal AmountInDollar)
        {

            if (AmountInDollar <= 0)
            {
                return false;
            }


            decimal DailyDeposit = clsAccounts.GetTransactionsInPeriod(this.AccountNumber, DaysPeriod, clsTransactions.enTransactions.Deposit);

            // Note: This Function Above, return Transactions Amounts In (Dollar)($)

            return ((AmountInDollar + DailyDeposit) < this.AccountTypes.DepositDailyLimit);
        }

    }

}
