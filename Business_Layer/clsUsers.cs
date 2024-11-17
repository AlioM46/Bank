using System;
using DataAccess_Layer;
using System.Data;

namespace Business_Layer
{
    public class clsUsers
    {



        public enum enMode { AddNew = 1, Update = 2 };
        public enMode Mode { get; set; }

        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public byte Role { get; set; }
        public DateTime CreatedDate { get; set; }

        // Composition of People
        public clsPeople People;



        public clsUsers(int UserID, int PersonID, string Username, string Password, bool IsActive, byte Role, DateTime CreatedDate)
        {

            this.UserID = UserID;
            this.PersonID = PersonID;

            People = clsPeople.Find(PersonID);

            this.Username = Username;
            this.Password = Password;
            this.IsActive = IsActive;
            this.Role = Role;
            this.CreatedDate = CreatedDate;
            Mode = enMode.Update;

        }

        public clsUsers()
        {

            this.UserID = -1;
            this.PersonID = -1;
            this.Username = "";
            this.Password = "";
            this.IsActive = false;
            this.Role = 0;
            this.CreatedDate = DateTime.MaxValue;
            Mode = enMode.AddNew;

        }

        private bool _AddNewUsers()
        {

            this.UserID = DataAccess_Layer.clsUsers.AddNewUsers(this.PersonID, this.Username, this.Password, this.IsActive, this.Role, this.CreatedDate);

            return this.UserID != -1;
        }

        private bool _UpdateUsers()
        {

            return DataAccess_Layer.clsUsers.UpdateUsers(this.UserID, this.PersonID, this.Username, this.Password, this.IsActive, this.Role, this.CreatedDate);
        }

        private bool _DeleteUsers()
        {

            return DataAccess_Layer.clsUsers.DeleteUsers(this.UserID);
        }


        public static clsUsers Find(string username, string HashedPassword)
        {

            int PersonID = -1;
            bool IsActive = false;
            byte Role = 0;
            int UserID = -1;    

            DateTime CreatedDate = new DateTime();
            CreatedDate = DateTime.MaxValue;


            if (DataAccess_Layer.clsUsers.FindByUserNameAndPassword(ref UserID, ref PersonID,  username, HashedPassword, ref IsActive, ref Role, ref CreatedDate))
            {

                return new clsUsers(UserID, PersonID, username, HashedPassword, IsActive, Role, CreatedDate);
            }
            else
            {
                return null;
            }
        }


        public static clsUsers Find(int UserID)
        {

            int PersonID = -1;
            string Username = "";
            string Password = "";
            bool IsActive = false;
            byte Role = 0;

            DateTime CreatedDate = new DateTime();
            CreatedDate = DateTime.MaxValue;


            if (DataAccess_Layer.clsUsers.Find(UserID, ref PersonID, ref Username, ref Password, ref IsActive, ref Role, ref CreatedDate))
            {

                return new clsUsers(UserID, PersonID, Username, Password, IsActive, Role, CreatedDate);
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
                    return _UpdateUsers();

                case enMode.AddNew:

                    if (_AddNewUsers())
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

        public static bool DoesUsersExists(int UserID)
        {
            return DataAccess_Layer.clsUsers.DoesUsersExists(UserID);
        }
        public static bool DoesUsersExists(string username, string password)
        {
            return DataAccess_Layer.clsUsers.DoesUsersExists(username, password);
        }

        public bool DoesUsersExists()
        {
            return DoesUsersExists(this.UserID);
        }

        public static bool IsUserNameAvailable(string username) { 
        return DataAccess_Layer.clsUsers.IsUserNameAvailable(username);
        }

        public static DataTable GetAllUsers()
        {
            return DataAccess_Layer.clsUsers.GetAllUsers();
        }

        public static bool IsValidCredentials(string username, string hashedPassword)
        {

            return DataAccess_Layer.clsUsers.IsValidCredentials(username, hashedPassword);
        }

        public static bool IsThePersonAvailableToConnectWithUser(int PersonID)
        {
        return DataAccess_Layer.clsUsers.IsThePersonAvailableToConnectWithUser(PersonID);    
        }

    }
}
