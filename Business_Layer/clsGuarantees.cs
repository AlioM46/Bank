using System;
using DataAccess_Layer;
using System.Data;

namespace Business_Layer
{
    public class clsGuarantees
    {



        public enum enMode { AddNew = 1, Update = 2 };
        public enMode Mode { get; set; }

        public int GuaranteeID { get; set; }
        public string GuaranteeItem { get; set; }
        public int LoanID { get; set; }
        public decimal EstimatedValue { get; set; }
        public string GuaranteeDescription { get; set; }

        // Composition of Loans
        public clsLoans Loans;



        public clsGuarantees(int GuaranteeID, string GuaranteeItem, int LoanID, decimal EstimatedValue, string GuaranteeDescription)
        {

            this.GuaranteeID = GuaranteeID;
            this.GuaranteeItem = GuaranteeItem;
            this.LoanID = LoanID;

            Loans = clsLoans.Find(LoanID);

            this.EstimatedValue = EstimatedValue;
            this.GuaranteeDescription = GuaranteeDescription;
            Mode = enMode.Update;

        }

        public clsGuarantees()
        {

            this.GuaranteeID = -1;
            this.GuaranteeItem = "";
            this.LoanID = -1;
            this.EstimatedValue = -1;
            this.GuaranteeDescription = "";
            Mode = enMode.AddNew;

        }

        private bool _AddNewGuarantees()
        {

            this.GuaranteeID = DataAccess_Layer.clsGuarantees.AddNewGuarantees(this.GuaranteeItem, this.LoanID, this.EstimatedValue, this.GuaranteeDescription);

            return this.GuaranteeID != -1;
        }

        private bool _UpdateGuarantees()
        {

            return DataAccess_Layer.clsGuarantees.UpdateGuarantees(this.GuaranteeID, this.GuaranteeItem, this.LoanID, this.EstimatedValue, this.GuaranteeDescription);
        }

        private bool _DeleteGuarantees()
        {

            return DataAccess_Layer.clsGuarantees.DeleteGuarantees(this.GuaranteeID);
        }

        public static clsGuarantees Find(int GuaranteeID)
        {

            string GuaranteeItem = "";
            int LoanID = -1;
            decimal EstimatedValue = -1;
            string GuaranteeDescription = "";

            if (DataAccess_Layer.clsGuarantees.Find(GuaranteeID, ref GuaranteeItem, ref LoanID, ref EstimatedValue, ref GuaranteeDescription))
            {

                return new clsGuarantees(GuaranteeID, GuaranteeItem, LoanID, EstimatedValue, GuaranteeDescription);
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
                    return _UpdateGuarantees();

                case enMode.AddNew:

                    if (_AddNewGuarantees())
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

        public static bool DoesGuaranteesExists(int GuaranteeID)
        {
            return DataAccess_Layer.clsGuarantees.DoesGuaranteesExists(GuaranteeID);
        }

        public bool DoesGuaranteesExists()
        {
            return DoesGuaranteesExists(this.GuaranteeID);
        }

        public static DataTable GetAllGuarantees()
        {
            return DataAccess_Layer.clsGuarantees.GetAllGuarantees();
        }


    }
}
