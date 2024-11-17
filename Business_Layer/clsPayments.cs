using System;
using DataAccess_Layer;
using System.Data;
using static System.Net.Mime.MediaTypeNames;

namespace Business_Layer
{
    public class clsPayments
    {



        public enum enMode { AddNew = 1, Update = 2 };
        public enMode Mode { get; set; }

        public int PaymentID { get; set; }
        public int ApplicationID { get; set; }
        public int TransactionID { get; set; }
        public string Description { get; set; }

        // Composition of Applications
        public clsApplications Applications;

        // Composition of Transactions
        public clsTransactions Transactions;



        public clsPayments(int PaymentID, int ApplicationID, int TransactionID, string Description)
        {

            this.PaymentID = PaymentID;
            this.ApplicationID = ApplicationID;

            Applications = clsApplications.Find(ApplicationID);

            this.TransactionID = TransactionID;

            Transactions = clsTransactions.Find(TransactionID);

            this.Description = Description;
            Mode = enMode.Update;

        }

        public clsPayments()
        {

            this.PaymentID = -1;
            this.ApplicationID = -1;
            this.TransactionID = -1;
            this.Description = "";
            Mode = enMode.AddNew;

        }

        private bool _AddNewPayments()
        {

            this.PaymentID = DataAccess_Layer.clsPayments.AddNewPayments(this.ApplicationID, this.TransactionID, this.Description);

            return this.PaymentID != -1;
        }

        private bool _UpdatePayments()
        {

            return DataAccess_Layer.clsPayments.UpdatePayments(this.PaymentID, this.ApplicationID, this.TransactionID, this.Description);
        }

        private bool _DeletePayments()
        {

            return DataAccess_Layer.clsPayments.DeletePayments(this.PaymentID);
        }

        public static clsPayments Find(int PaymentID)
        {

            int ApplicationID = -1;
            int TransactionID = -1;
            string Description = "";


            if (DataAccess_Layer.clsPayments.Find(PaymentID, ref ApplicationID, ref TransactionID, ref Description))
            {

                return new clsPayments(PaymentID, ApplicationID, TransactionID, Description);
            }
            else
            {
                return null;
            }
        }

        public static clsPayments FindPaymentByApplicationID(int ApplicationID)
        {

            int PaymentID = -1;
            int TransactionID = -1;
            string Description = "";


            if (DataAccess_Layer.clsPayments.FindByApplicationID(ref PaymentID, ApplicationID, ref TransactionID, ref Description))
            {

                return new clsPayments(PaymentID, ApplicationID, TransactionID, Description);
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
                    return _UpdatePayments();

                case enMode.AddNew:

                    if (_AddNewPayments())
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

        public static bool DoesPaymentsExists(int PaymentID)
        {
            return DataAccess_Layer.clsPayments.DoesPaymentsExists(PaymentID);
        }

        public bool DoesPaymentsExists()
        {
            return DoesPaymentsExists(this.PaymentID);
        }

        public static DataTable GetAllPayments()
        {
            return DataAccess_Layer.clsPayments.GetAllPayments();
        }

        public bool CreatePayment(clsApplications application)
        {

            if (application.ApplicationTypes.FreeForFirstTime &&
                !clsAccounts.DoesCustomerHaveActiveAccount(application.CustomerID))
            {
                if (!HandleTransaction(application, 0, "First-time free application"))
                {
                    return false; // Handle failure
                }

                return this.Save(); // Save the application changes
            }

            // Check if the account has sufficient funds for the application fee

            if (application.Accounts.AmountInUSD < application.ApplicationTypes.ApplicationFees)
            {
                return false; // Insufficient funds
            }

            // Convert application fees to account currency
            decimal amountInAccountCurrency = application.ApplicationTypes.ApplicationFees /
                                               application.Accounts.Currency.ExchangeRateToUSD;

            // Attempt to process the payment
            if (!HandleTransaction(application, amountInAccountCurrency, "Application fee payment"))
            {
                return false; // Handle failure
            }

            return this.Save(); // Save the application changes

        }


        private bool HandleTransaction(clsApplications application, decimal amount, string description)
        {
            // Attempt to withdraw the specified amount
            if (!application.Accounts.Withdraw(amount))
            {
                return false; // Withdrawal failed
            }

            // Create and save a transaction
            clsTransactions transaction = new clsTransactions();
            if (!transaction.CreateTransaction(amount, application.AccountID,
                                                clsTransactions.enTransactions.Withdraw,
                                                application.CustomerID))
            {
                return false; // Transaction creation failed
            }

            // Update application properties
            this.Description = description;
            this.ApplicationID = application.ApplicationID;
            this.TransactionID = transaction.TransactionID;

            return true; // Transaction successfully processed
        }


    }
}
