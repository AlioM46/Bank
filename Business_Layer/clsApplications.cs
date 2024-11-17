using System;
using DataAccess_Layer;
using System.Data;

namespace Business_Layer
{
    public class clsApplications
    {



        public enum enMode { AddNew = 1, Update = 2 };
        public enMode Mode { get; set; }

        public int ApplicationID { get; set; }
        public int CustomerID { get; set; }
        public int ApplicationTypeID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public int ApplicationStatus { get; set; }
        public int AccountID { get; set; }
        public string ApplicationDescription { get; set; }

        public enum enApplicationStatus { Pending = 1, Approved = 2, Rejected = 3, Cancelled = 4 };

        public enum enApplicationType { Account = 1, Loan = 2 };

        // Composition of Customers
        public clsCustomers Customers;

        // Composition of ApplicationTypes
        public clsApplicationTypes ApplicationTypes;

        // Composition of Accounts
        public clsAccounts Accounts;



        public clsApplications(int ApplicationID, int CustomerID, int ApplicationTypeID, DateTime ApplicationDate, DateTime LastUpdateDate, int ApplicationStatus, int AccountID, string ApplicationDescription)
        {

            this.ApplicationID = ApplicationID;

            Customers = clsCustomers.Find(ApplicationID);

            this.CustomerID = CustomerID;
            this.ApplicationTypeID = ApplicationTypeID;

            ApplicationTypes = clsApplicationTypes.Find(ApplicationTypeID);

            this.ApplicationDate = ApplicationDate;
            this.LastUpdateDate = LastUpdateDate;
            this.ApplicationStatus = ApplicationStatus;
            this.AccountID = AccountID;

            Accounts = clsAccounts.Find(AccountID);

            this.ApplicationDescription = ApplicationDescription;
            Mode = enMode.Update;

        }

        public clsApplications()
        {

            this.ApplicationID = -1;
            this.CustomerID = -1;
            this.ApplicationTypeID = -1;
            this.ApplicationDate = DateTime.MaxValue;
            this.LastUpdateDate = DateTime.MaxValue;
            this.ApplicationStatus = -1;
            this.AccountID = -1;
            this.ApplicationDescription = "";
            Mode = enMode.AddNew;

        }

        private bool _AddNewApplications()
        {

            this.ApplicationID = DataAccess_Layer.clsApplications.AddNewApplications(this.CustomerID, this.ApplicationTypeID, this.ApplicationDate, this.LastUpdateDate, this.ApplicationStatus, this.AccountID, this.ApplicationDescription);

            return this.ApplicationID != -1;
        }

        private bool _UpdateApplications()
        {

            return DataAccess_Layer.clsApplications.UpdateApplications(this.ApplicationID, this.CustomerID, this.ApplicationTypeID, this.ApplicationDate, this.LastUpdateDate, this.ApplicationStatus, this.AccountID, this.ApplicationDescription);
        }

        public bool Delete()
        {

            return DataAccess_Layer.clsApplications.DeleteApplications(this.ApplicationID);
        }

        public static bool Delete(int ApplicationID)
        {

            return DataAccess_Layer.clsApplications.DeleteApplications(ApplicationID);
        }

        public static bool DeleteApplicationByAccountNumber(int AccountNumber)
        {

            return DataAccess_Layer.clsApplications.DeleteApplicationByAccountID(AccountNumber);
        }


        public static clsApplications Find(int ApplicationID)
        {

            int CustomerID = -1;
            int ApplicationTypeID = -1;

            DateTime ApplicationDate = new DateTime();
            ApplicationDate = DateTime.MaxValue;


            DateTime LastUpdateDate = new DateTime();
            LastUpdateDate = DateTime.MaxValue;

            int ApplicationStatus = -1;
            int AccountID = -1;
            string ApplicationDescription = "";

            if (DataAccess_Layer.clsApplications.Find(ApplicationID, ref CustomerID, ref ApplicationTypeID, ref ApplicationDate, ref LastUpdateDate, ref ApplicationStatus, ref AccountID, ref ApplicationDescription))
            {

                return new clsApplications(ApplicationID, CustomerID, ApplicationTypeID, ApplicationDate, LastUpdateDate, ApplicationStatus, AccountID, ApplicationDescription);
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
                    this.LastUpdateDate = DateTime.Now;
                    return _UpdateApplications();

                case enMode.AddNew:

                    if (_AddNewApplications())
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

        public static bool DoesApplicationsExists(int ApplicationID)
        {
            return DataAccess_Layer.clsApplications.DoesApplicationsExists(ApplicationID);
        }

        public bool DoesApplicationsExists()
        {
            return DoesApplicationsExists(this.ApplicationID);
        }

        public static DataTable GetAllApplications()
        {
            return DataAccess_Layer.clsApplications.GetAllApplications();
        }


    }
}
