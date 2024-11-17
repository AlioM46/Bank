using System;
using DataAccess_Layer;
using System.Data;

namespace Business_Layer
{
    public class clsApplicationTypes
    {



        public enum enMode { AddNew = 1, Update = 2 };
        public enMode Mode { get; set; }

        public int ApplicationTypeID { get; set; }
        public string ApplicationType { get; set; }
        public decimal ApplicationFees { get; set; }
        public bool RequiresDocuments { get; set; }
        public bool FreeForFirstTime { get; set; }

        public enum enApplicationTypes
        {
            OpenAccount = 1,
            Loan
        }

        public clsApplicationTypes(int ApplicationTypeID, string ApplicationType, decimal ApplicationFees, bool RequiresDocuments, bool FreeForFirstTime)
        {

            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationType = ApplicationType;
            this.ApplicationFees = ApplicationFees;
            this.RequiresDocuments = RequiresDocuments;
            this.FreeForFirstTime = FreeForFirstTime;
            Mode = enMode.Update;

        }

        public clsApplicationTypes()
        {

            this.ApplicationTypeID = -1;
            this.ApplicationType = "";
            this.ApplicationFees = -1;
            this.RequiresDocuments = false;
            this.FreeForFirstTime = false;
            Mode = enMode.AddNew;

        }

        private bool _AddNewApplicationTypes()
        {

            this.ApplicationTypeID = DataAccess_Layer.clsApplicationTypes.AddNewApplicationTypes(this.ApplicationType, this.ApplicationFees, this.RequiresDocuments, this.FreeForFirstTime);

            return this.ApplicationTypeID != -1;
        }

        private bool _UpdateApplicationTypes()
        {

            return DataAccess_Layer.clsApplicationTypes.UpdateApplicationTypes(this.ApplicationTypeID, this.ApplicationType, this.ApplicationFees, this.RequiresDocuments, this.FreeForFirstTime);
        }

        private bool _DeleteApplicationTypes()
        {

            return DataAccess_Layer.clsApplicationTypes.DeleteApplicationTypes(this.ApplicationTypeID);
        }

        public static clsApplicationTypes Find(int ApplicationTypeID)
        {

            string ApplicationType = "";
            decimal ApplicationFees = -1;
            bool RequiresDocuments = false;
            bool FreeForFirstTime = false;

            if (DataAccess_Layer.clsApplicationTypes.Find(ApplicationTypeID, ref ApplicationType, ref ApplicationFees, ref RequiresDocuments, ref FreeForFirstTime))
            {

                return new clsApplicationTypes(ApplicationTypeID, ApplicationType, ApplicationFees, RequiresDocuments, FreeForFirstTime);
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
                    return _UpdateApplicationTypes();

                case enMode.AddNew:

                    if (_AddNewApplicationTypes())
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

        public static bool DoesApplicationTypesExists(int ApplicationTypeID)
        {
            return DataAccess_Layer.clsApplicationTypes.DoesApplicationTypesExists(ApplicationTypeID);
        }

        public bool DoesApplicationTypesExists()
        {
            return DoesApplicationTypesExists(this.ApplicationTypeID);
        }

        public static DataTable GetAllApplicationTypes()
        {
            return DataAccess_Layer.clsApplicationTypes.GetAllApplicationTypes();
        }


    }
}
