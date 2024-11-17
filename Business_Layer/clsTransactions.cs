using System;
using DataAccess_Layer;
using System.Data;

namespace Business_Layer
{
    public class clsTransactions
    {



        public enum enMode { AddNew = 1, Update = 2 };
        public enMode Mode { get; set; }

        public int TransactionID { get; set; }
        public int AccountID { get; set; }
        public int TransactionTypeID { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal TransactionAmount { get; set; }
        public int CustomerID { get; set; }

        // Composition of Accounts
        public clsAccounts Accounts;

        // Composition of TransactionTypes
        public clsTransactionTypes TransactionTypes;

        // Composition of Customers
        public clsCustomers Customers;

        public enum enTransactions
        {
            Deposit = 1,
            Withdraw = 2,
            Transfer = 3,
          LoanPayment = 4,
            Refund = 5
        }



        public clsTransactions(int TransactionID, int AccountID, int TransactionTypeID, DateTime TransactionDate, decimal TransactionAmount, int CustomerID)
        {

            this.TransactionID = TransactionID;
            this.AccountID = AccountID;

            Accounts = clsAccounts.Find(AccountID);

            this.TransactionTypeID = TransactionTypeID;

            TransactionTypes = clsTransactionTypes.Find(TransactionTypeID);

            this.TransactionDate = TransactionDate;
            this.TransactionAmount = TransactionAmount;
            this.CustomerID = CustomerID;

            Customers = clsCustomers.Find(CustomerID);

            Mode = enMode.Update;

        }

        public clsTransactions()
        {

            this.TransactionID = -1;
            this.AccountID = -1;
            this.TransactionTypeID = -1;
            this.TransactionDate = DateTime.MaxValue;
            this.TransactionAmount = -1;
            this.CustomerID = -1;
            Mode = enMode.AddNew;

        }

        private bool _AddNewTransactions()
        {

            this.TransactionID = DataAccess_Layer.clsTransactions.AddNewTransactions(this.AccountID, this.TransactionTypeID, this.TransactionDate, this.TransactionAmount, this.CustomerID);

            return this.TransactionID != -1;
        }

        private bool _UpdateTransactions()
        {

            return DataAccess_Layer.clsTransactions.UpdateTransactions(this.TransactionID, this.AccountID, this.TransactionTypeID, this.TransactionDate, this.TransactionAmount, this.CustomerID);
        }

        private bool _DeleteTransactions()
        {

            return DataAccess_Layer.clsTransactions.DeleteTransactions(this.TransactionID);
        }

        public static clsTransactions Find(int TransactionID)
        {

            int AccountID = -1;
            int TransactionTypeID = -1;

            DateTime TransactionDate = new DateTime();
            TransactionDate = DateTime.MaxValue;

            decimal TransactionAmount = -1;
            int CustomerID = -1;

            if (DataAccess_Layer.clsTransactions.Find(TransactionID, ref AccountID, ref TransactionTypeID, ref TransactionDate, ref TransactionAmount, ref CustomerID))
            {

                return new clsTransactions(TransactionID, AccountID, TransactionTypeID, TransactionDate, TransactionAmount, CustomerID);
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
                    return _UpdateTransactions();

                case enMode.AddNew:

                    if (_AddNewTransactions())
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

        public static bool DoesTransactionsExists(int TransactionID)
        {
            return DataAccess_Layer.clsTransactions.DoesTransactionsExists(TransactionID);
        }

        public bool DoesTransactionsExists()
        {
            return DoesTransactionsExists(this.TransactionID);
        }

        public static DataTable GetAllTransactions()
        {
            return DataAccess_Layer.clsTransactions.GetAllTransactions();
        }

        public bool CreateTransaction(decimal Amount, int AccountID,  enTransactions TransactionTypeID, int CustomerID)
        {
            this.AccountID = AccountID;
            this.TransactionAmount = Amount;
            this.TransactionTypeID = (int)TransactionTypeID;

            this.TransactionDate = DateTime.Now ;
            this.CustomerID = CustomerID;

            if (!Save()) {
                return false;
            }

            return true;

        }

    }
}
