using System;
using DataAccess_Layer;
using System.Data;

namespace Business_Layer
{
    public class clsCustomers
    {



        public enum enMode { AddNew = 1, Update = 2 };
        public enMode Mode { get; set; }

        public int CustomerID { get; set; }
        public int PersonID { get; set; }
        public string CustomerName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }

        // Composition of People
        public clsPeople People;



        public clsCustomers(int CustomerID, int PersonID, string CustomerName, string Password, bool IsActive, DateTime CreatedDate)
        {

            this.CustomerID = CustomerID;
            this.PersonID = PersonID;

            People = clsPeople.Find(PersonID);

            this.CustomerName = CustomerName;
            this.Password = Password;
            this.IsActive = IsActive;
            this.CreatedDate = CreatedDate;
            Mode = enMode.Update;

        }

        public clsCustomers()
        {

            this.CustomerID = -1;
            this.PersonID = -1;
            this.CustomerName = "";
            this.Password = "";
            this.IsActive = false;
            this.CreatedDate = DateTime.MaxValue;
            Mode = enMode.AddNew;

        }

        private bool _AddNewCustomers()
        {

            this.CustomerID = DataAccess_Layer.clsCustomers.AddNewCustomers(this.PersonID, this.CustomerName, this.Password, this.IsActive, this.CreatedDate);

            return this.CustomerID != -1;
        }

        private bool _UpdateCustomers()
        {

            return DataAccess_Layer.clsCustomers.UpdateCustomers(this.CustomerID, this.PersonID, this.CustomerName, this.Password, this.IsActive, this.CreatedDate);
        }

        public bool Delete()
        {

            return DataAccess_Layer.clsCustomers.DeleteCustomers(this.CustomerID);
        }
        public static bool Delete(int CustomerID)
        {

            return DataAccess_Layer.clsCustomers.DeleteCustomers(CustomerID);
        }

        public static clsCustomers Find(int CustomerID)
        {

            int PersonID = -1;
            string CustomerName = "";
            string Password = "";
            bool IsActive = false;

            DateTime CreatedDate = new DateTime();
            CreatedDate = DateTime.MaxValue;


            if (DataAccess_Layer.clsCustomers.Find(CustomerID, ref PersonID, ref CustomerName, ref Password, ref IsActive, ref CreatedDate))
            {

                return new clsCustomers(CustomerID, PersonID, CustomerName, Password, IsActive, CreatedDate);
            }
            else
            {
                return null;
            }
        }
        public static clsCustomers Find(string name, string password)
        {

            int PersonID = -1;
            int CustomerID = -1;
            bool IsActive = false;
            DateTime CreatedDate = new DateTime();
            CreatedDate = DateTime.MaxValue;


            if (DataAccess_Layer.clsCustomers.Find(ref CustomerID, ref PersonID, name, password, ref IsActive, ref CreatedDate))
            {

                return new clsCustomers(CustomerID, PersonID, name, password, IsActive, CreatedDate);
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
                    return _UpdateCustomers();

                case enMode.AddNew:

                    if (_AddNewCustomers())
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

        public static bool DoesCustomersExists(int CustomerID)
        {
            return DataAccess_Layer.clsCustomers.DoesCustomersExists(CustomerID);
        }
        public static bool DoesCustomersExists(string name, string password)
        {
            return DataAccess_Layer.clsCustomers.DoesCustomersExists(name, password);
        }

        public bool DoesCustomersExists()
        {
            return DoesCustomersExists(this.CustomerID);
        }

        public static bool IsValidCredentials(string name, string password)
        {
            return DataAccess_Layer.clsCustomers.IsValidCredentials(name, password);
        }

        public static DataTable GetAllCustomers()
        {
            return DataAccess_Layer.clsCustomers.GetAllCustomers();
        }

        public static bool IsThePersonAvailableToConnectWithCustomer(int PersonID)
        {
            return DataAccess_Layer.clsCustomers.IsThePersonAvailableToConnectWithCustomer(PersonID);
        }

        public static bool IsCustomerNameAvailable(string CustomerName)
        {
            return DataAccess_Layer.clsCustomers.IsCustomerNameAvailable(CustomerName);

        }


        public static DataTable GetAllAccounts(int CustomerID)
        {
            return clsAccounts.GetAllAccountsForCustomer(CustomerID);
        }


        public static DataTable GetTop5CustomerBalance()
        {
            return DataAccess_Layer.clsCustomers.GetTop5CustomerBalance();
        }


        public static double GetAllAccountsBalanceInDollar(int CustomerID)
        {

            return DataAccess_Layer.clsCustomers.GetAllAccountsBalanceInDollar(CustomerID);

        }
        public int YourBalanceRank()
        {

            return DataAccess_Layer.clsCustomers.YourBalanceRank(this.CustomerID);

        }
        public static int YourBalanceRank(int CustomerID)
        {

            return DataAccess_Layer.clsCustomers.YourBalanceRank(CustomerID);

        }


    }
}
