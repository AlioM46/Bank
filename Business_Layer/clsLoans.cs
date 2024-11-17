using System;
using DataAccess_Layer;
using System.Data;

namespace Business_Layer
{
    public class clsLoans
    {



        public enum enMode { AddNew = 1, Update = 2 };
        public enMode Mode { get; set; }

        public int LoanID { get; set; }
        public decimal Amount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int LoanTypeID { get; set; }
        public int Status { get; set; }
        public decimal AllPayments { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public int ApplicationID { get; set; }

        // Composition of LoanTypes
        public clsLoanTypes LoanTypes;

        // Composition of Applications
        public clsApplications Applications;


        public enum enLoanStatus { Pending = 1, Rejected = 2, InRepayment = 3, Defaulted = 4, Closed = 5, Fulfilled = 6 }



        public clsLoans(int LoanID, decimal Amount, DateTime StartDate, DateTime EndDate, int LoanTypeID, int Status, decimal AllPayments, DateTime LastUpdateDate, int ApplicationID)
        {

            this.LoanID = LoanID;
            this.Amount = Amount;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.LoanTypeID = LoanTypeID;

            LoanTypes = clsLoanTypes.Find(LoanTypeID);

            this.Status = Status;
            this.AllPayments = AllPayments;
            this.LastUpdateDate = LastUpdateDate;
            this.ApplicationID = ApplicationID;

            Applications = clsApplications.Find(ApplicationID);

            Mode = enMode.Update;

        }

        public clsLoans()
        {

            this.LoanID = -1;
            this.Amount = -1;
            this.StartDate = DateTime.MaxValue;
            this.EndDate = DateTime.MaxValue;
            this.LoanTypeID = -1;
            this.Status = -1;
            this.AllPayments = -1;
            this.LastUpdateDate = DateTime.MaxValue;
            this.ApplicationID = -1;
            Mode = enMode.AddNew;

        }

        private bool _AddNewLoans()
        {

            this.LoanID = DataAccess_Layer.clsLoans.AddNewLoans(this.Amount, this.StartDate, this.EndDate, this.LoanTypeID, this.Status, this.AllPayments, this.LastUpdateDate, this.ApplicationID);

            return this.LoanID != -1;
        }

        private bool _UpdateLoans()
        {

            return DataAccess_Layer.clsLoans.UpdateLoans(this.LoanID, this.Amount, this.StartDate, this.EndDate, this.LoanTypeID, this.Status, this.AllPayments, this.LastUpdateDate, this.ApplicationID);
        }

        private bool _DeleteLoans()
        {

            return DataAccess_Layer.clsLoans.DeleteLoans(this.LoanID);
        }



        public static clsLoans FindLoanByApplicationID(int ApplicationID)
        {

            decimal Amount = -1;

            DateTime StartDate = new DateTime();
            DateTime EndDate = new DateTime();
            int LoanTypeID = -1;
            int Status = -1;
            decimal AllPayments = -1;

            DateTime LastUpdateDate = new DateTime();
            LastUpdateDate = DateTime.MaxValue;

            int LoanID = -1;

            if (DataAccess_Layer.clsLoans.FindLoanByApplicationID(ref LoanID, ref Amount, ref StartDate, ref EndDate, ref LoanTypeID, ref Status, ref AllPayments, ref LastUpdateDate, ApplicationID))
            {

                return new clsLoans(LoanID, Amount, StartDate, EndDate, LoanTypeID, Status, AllPayments, LastUpdateDate, ApplicationID);
            }
            else
            {
                return null;
            }
        }

        public static clsLoans Find(int LoanID)
        {

            decimal Amount = -1;

            DateTime StartDate = new DateTime();
            DateTime EndDate = new DateTime();
            int LoanTypeID = -1;
            int Status = -1;
            decimal AllPayments = -1;

            DateTime LastUpdateDate = new DateTime();
            LastUpdateDate = DateTime.MaxValue;

            int ApplicationID = -1;

            if (DataAccess_Layer.clsLoans.Find(LoanID, ref Amount, ref StartDate, ref EndDate, ref LoanTypeID, ref Status, ref AllPayments, ref LastUpdateDate, ref ApplicationID))
            {

                return new clsLoans(LoanID, Amount, StartDate, EndDate, LoanTypeID, Status, AllPayments, LastUpdateDate, ApplicationID);
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
                    return _UpdateLoans();

                case enMode.AddNew:

                    if (_AddNewLoans())
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

        public static bool DoesLoansExists(int LoanID)
        {
            return DataAccess_Layer.clsLoans.DoesLoansExists(LoanID);
        }

        public bool DoesLoansExists()
        {
            return DoesLoansExists(this.LoanID);
        }

        public static DataTable GetAllLoans()
        {
            return DataAccess_Layer.clsLoans.GetAllLoans();
        }

        public bool Reject()
        {
            this.Status = (int)clsLoans.enLoanStatus.Rejected;

            return this.Save();
        }
        public bool Approve(int CustomerID)
        {
            this.Status = (int)clsLoans.enLoanStatus.InRepayment;

            if (this.Save() && this.Applications.Accounts.Deposit((this.Amount / this.Applications.Accounts.Currency.ExchangeRateToUSD), CustomerID, clsTransactions.enTransactions.Deposit))
            {
                return true;
            }

            return false;
        }

    }
}
