using System;
using DataAccess_Layer;
using System.Data;

namespace Business_Layer
{
    public class clsAccountTypes
    {
        public enum enMode { AddNew = 1, Update = 2 };
        public enMode Mode { get; set; }

        public int AccountTypeID { get; set; }
        public string AccountType { get; set; }
        public decimal Fees { get; set; }
        public string Description { get; set; }

        public decimal DepositDailyLimit { get; set; }
        public decimal WithdrawDailyLimit { get; set; }

        // Constructor for updating account types
        public clsAccountTypes(int AccountTypeID, string AccountType, decimal Fees, string Description, decimal DepositDailyLimit, decimal WithdrawDailyLimit)
        {
            this.AccountTypeID = AccountTypeID;
            this.AccountType = AccountType;
            this.Fees = Fees;
            this.Description = Description;
            this.DepositDailyLimit = DepositDailyLimit;
            this.WithdrawDailyLimit = WithdrawDailyLimit;
            Mode = enMode.Update;
        }

        // Default constructor for adding new account types
        public clsAccountTypes()
        {
            this.AccountTypeID = -1;
            this.AccountType = "";
            this.Fees = -1;
            this.Description = "";
            this.DepositDailyLimit = 0;
            this.WithdrawDailyLimit = 0;
            Mode = enMode.AddNew;
        }

        private bool _AddNewAccountTypes()
        {
            this.AccountTypeID = DataAccess_Layer.clsAccountTypes.AddNewAccountTypes(
                this.AccountType,
                this.Fees,
                this.Description,
                this.DepositDailyLimit,
                this.WithdrawDailyLimit);

            return this.AccountTypeID != -1;
        }

        private bool _UpdateAccountTypes()
        {
            return DataAccess_Layer.clsAccountTypes.UpdateAccountTypes(
                this.AccountTypeID,
                this.AccountType,
                this.Fees,
                this.Description,
                this.DepositDailyLimit,
                this.WithdrawDailyLimit);
        }

        private bool _DeleteAccountTypes()
        {
            return DataAccess_Layer.clsAccountTypes.DeleteAccountTypes(this.AccountTypeID);
        }

        public static clsAccountTypes Find(int AccountTypeID)
        {
            string AccountType = "";
            decimal Fees = -1;
            string Description = "";
            decimal DepositDailyLimit = 0;
            decimal WithdrawDailyLimit = 0;

            if (DataAccess_Layer.clsAccountTypes.Find(
                AccountTypeID,
                ref AccountType,
                ref Fees,
                ref Description,
                ref WithdrawDailyLimit,
                ref DepositDailyLimit))
            {
                return new clsAccountTypes(AccountTypeID, AccountType, Fees, Description, DepositDailyLimit, WithdrawDailyLimit);
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
                    return _UpdateAccountTypes();

                case enMode.AddNew:
                    if (_AddNewAccountTypes())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                default:
                    return false;
            }
        }

        public static bool DoesAccountTypesExists(int AccountTypeID)
        {
            return DataAccess_Layer.clsAccountTypes.DoesAccountTypesExists(AccountTypeID);
        }

        public bool DoesAccountTypesExists()
        {
            return DoesAccountTypesExists(this.AccountTypeID);
        }

        public static DataTable GetAllAccountTypes()
        {
            return DataAccess_Layer.clsAccountTypes.GetAllAccountTypes();
        }
    }
}
