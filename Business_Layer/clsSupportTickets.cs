using System;
using DataAccess_Layer;
using System.Data;

namespace Business_Layer
{
    public class clsSupportTickets
    {



        public enum enMode { AddNew = 1, Update = 2 };
        public enMode Mode { get; set; }

        public int TicketID { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public int TicketPublisherID { get; set; }
        public string LastResponse { get; set; }
        public int LastResponserID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastResponseDate { get; set; }

        // Composition of Customers
        public clsCustomers Customers;

        // Composition of Users
        public clsUsers Users;



        public clsSupportTickets(int TicketID, string Subject, string Description, int TicketPublisherID, string LastResponse, int LastResponserID, DateTime CreatedDate, DateTime LastResponseDate)
        {

            this.TicketID = TicketID;
            this.Subject = Subject;
            this.Description = Description;
            this.TicketPublisherID = TicketPublisherID;

            Customers = clsCustomers.Find(TicketPublisherID);

            this.LastResponse = LastResponse;
            this.LastResponserID = LastResponserID;

            Users = clsUsers.Find(LastResponserID);

            this.CreatedDate = CreatedDate;
            this.LastResponseDate = LastResponseDate;
            Mode = enMode.Update;

        }

        public clsSupportTickets()
        {

            this.TicketID = -1;
            this.Subject = "";
            this.Description = "";
            this.TicketPublisherID = -1;
            this.LastResponse = "";
            this.LastResponserID = -1;
            this.CreatedDate = DateTime.MaxValue;
            this.LastResponseDate = DateTime.MaxValue;
            Mode = enMode.AddNew;

        }

        private bool _AddNewSupportTickets()
        {

            this.TicketID = DataAccess_Layer.clsSupportTickets.AddNewSupportTickets(this.Subject, this.Description, this.TicketPublisherID, this.LastResponse, this.LastResponserID, this.CreatedDate, this.LastResponseDate);

            return this.TicketID != -1;
        }

        private bool _UpdateSupportTickets()
        {

            return DataAccess_Layer.clsSupportTickets.UpdateSupportTickets(this.TicketID, this.Subject, this.Description, this.TicketPublisherID, this.LastResponse, this.LastResponserID, this.CreatedDate, this.LastResponseDate);
        }

        private bool _DeleteSupportTickets()
        {

            return DataAccess_Layer.clsSupportTickets.DeleteSupportTickets(this.TicketID);
        }

        public static clsSupportTickets Find(int TicketID)
        {

            string Subject = "";
            string Description = "";
            int TicketPublisherID = -1;
            string LastResponse = "";
            int LastResponserID = -1;

            DateTime CreatedDate = new DateTime();
            CreatedDate = DateTime.MaxValue;


            DateTime LastResponseDate = new DateTime();
            LastResponseDate = DateTime.MaxValue;


            if (DataAccess_Layer.clsSupportTickets.Find(TicketID, ref Subject, ref Description, ref TicketPublisherID, ref LastResponse, ref LastResponserID, ref CreatedDate, ref LastResponseDate))
            {

                return new clsSupportTickets(TicketID, Subject, Description, TicketPublisherID, LastResponse, LastResponserID, CreatedDate, LastResponseDate);
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
                    return _UpdateSupportTickets();

                case enMode.AddNew:

                    if (_AddNewSupportTickets())
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

        public static bool DoesSupportTicketsExists(int TicketID)
        {
            return DataAccess_Layer.clsSupportTickets.DoesSupportTicketsExists(TicketID);
        }

        public bool DoesSupportTicketsExists()
        {
            return DoesSupportTicketsExists(this.TicketID);
        }

        public static DataTable GetAllSupportTickets()
        {
            return DataAccess_Layer.clsSupportTickets.GetAllSupportTickets();
        }


    
        public static DataTable GetAllSupportTicketsForCustomer(int CustomerID)
        {
            return DataAccess_Layer.clsSupportTickets.GetAllSupportTicketsForCustomer(CustomerID);

        }


    }
}
