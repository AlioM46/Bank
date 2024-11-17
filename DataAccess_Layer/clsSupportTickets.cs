using System;
using Microsoft.Data.SqlClient;
using System.Data;


namespace DataAccess_Layer
{

    public class clsSupportTickets
    {



        public static int AddNewSupportTickets(string Subject, string Description, int TicketPublisherID, string LastResponse, int LastResponserID, DateTime CreatedDate, DateTime LastResponseDate)
        {
            int TicketID = -1;
            string query = $"INSERT INTO SupportTickets (Subject, Description, TicketPublisherID, LastResponse, LastResponserID, CreatedDate, LastResponseDate)VALUES (@Subject, @Description, @TicketPublisherID, @LastResponse, @LastResponserID, @CreatedDate, @LastResponseDate); SELECT SCOPE_IDENTITY();";

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {


                    Command.Parameters.AddWithValue("@Subject", Subject);

                    if (Description != "" && Description != null)
                    {

                        Command.Parameters.AddWithValue("@Description", Description);
                    }
                    else
                    {

                        Command.Parameters.AddWithValue("@Description", DBNull.Value);
                    }

                    Command.Parameters.AddWithValue("@TicketPublisherID", TicketPublisherID);

                    if (LastResponse != "" && LastResponse != null)
                    {

                        Command.Parameters.AddWithValue("@LastResponse", LastResponse);
                    }
                    else
                    {

                        Command.Parameters.AddWithValue("@LastResponse", DBNull.Value);
                    }

                    if (LastResponserID != -1 && LastResponserID != null)
                    {

                        Command.Parameters.AddWithValue("@LastResponserID", LastResponserID);
                    }
                    else
                    {

                        Command.Parameters.AddWithValue("@LastResponserID", DBNull.Value);
                    }

                    Command.Parameters.AddWithValue("@CreatedDate", CreatedDate);

                    if (LastResponseDate != DateTime.MaxValue && LastResponseDate != null)
                    {

                        Command.Parameters.AddWithValue("@LastResponseDate", LastResponseDate);
                    }
                    else
                    {

                        Command.Parameters.AddWithValue("@LastResponseDate", DBNull.Value);
                    }



                    try
                    {
                        Connection.Open();
                        object result = Command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                        {
                            TicketID = InsertedID;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log exception or handle accordingly
                        throw new ApplicationException("An error occurred while adding a new record.", ex);
                    }
                }
            }

            return TicketID;
        }
        public static bool UpdateSupportTickets(int TicketID, string Subject, string Description, int TicketPublisherID, string LastResponse, int LastResponserID, DateTime CreatedDate, DateTime LastResponseDate)
        {
            int RowsAffected = -1;
            string query = @"
    UPDATE SupportTickets 
    SET 
        Subject = @Subject,
        Description = @Description,
        TicketPublisherID = @TicketPublisherID,
        LastResponse = @LastResponse,
        LastResponserID = @LastResponserID,
        CreatedDate = @CreatedDate,
        LastResponseDate = @LastResponseDate
    WHERE 
        TicketID = @TicketID;
";
            ;

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {

                    Command.Parameters.AddWithValue("@TicketID", TicketID);

                    Command.Parameters.AddWithValue("@Subject", Subject);

                    if (Description != "" && Description != null)
                    {

                        Command.Parameters.AddWithValue("@Description", Description);
                    }
                    else
                    {

                        Command.Parameters.AddWithValue("@Description", DBNull.Value);
                    }

                    Command.Parameters.AddWithValue("@TicketPublisherID", TicketPublisherID);

                    if (LastResponse != "" && LastResponse != null)
                    {

                        Command.Parameters.AddWithValue("@LastResponse", LastResponse);
                    }
                    else
                    {

                        Command.Parameters.AddWithValue("@LastResponse", DBNull.Value);
                    }

                    if (LastResponserID != -1 && LastResponserID != null)
                    {

                        Command.Parameters.AddWithValue("@LastResponserID", LastResponserID);
                    }
                    else
                    {

                        Command.Parameters.AddWithValue("@LastResponserID", DBNull.Value);
                    }

                    Command.Parameters.AddWithValue("@CreatedDate", CreatedDate);

                    if (LastResponseDate != DateTime.MaxValue && LastResponseDate != null)
                    {

                        Command.Parameters.AddWithValue("@LastResponseDate", LastResponseDate);
                    }
                    else
                    {

                        Command.Parameters.AddWithValue("@LastResponseDate", DBNull.Value);
                    }



                    try
                    {
                        Connection.Open();
                        RowsAffected = Command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Log exception or handle accordingly
                        throw new ApplicationException("An error occurred while Updating a record.", ex);
                    }
                }
            }
            return (RowsAffected > 0);
        }


        public static bool DeleteSupportTickets(int TicketID)
        {

            int RowsAffected = -1;

            string query = " DELETE FROM SupportTickets WHERE TicketID = @TicketID";


            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.AddWithValue("@TicketID", TicketID);
                    try
                    {
                        Connection.Open();
                        RowsAffected = Command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Log exception or handle accordingly
                        throw new ApplicationException("An error occurred while Deleting a record.", ex);
                    }
                }
            }
            return (RowsAffected > 0);
        }


        public static bool Find(int TicketID, ref string Subject, ref string Description, ref int TicketPublisherID, ref string LastResponse, ref int LastResponserID, ref DateTime CreatedDate, ref DateTime LastResponseDate)
        {
            bool IsFound = false;
            string query = "select * from SupportTickets where TicketID = @TicketID";

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.AddWithValue("@TicketID", TicketID);
                    try
                    {
                        Connection.Open();
                        SqlDataReader Reader = Command.ExecuteReader();
                        if (Reader.Read())
                        {

                            IsFound = true;
                            Subject = (string)Reader["Subject"];
                            if (Reader["Description"] != DBNull.Value)
                            {
                                Description = (string)Reader["Description"];
                            }
                            else
                            {
                                Description = "";
                            }
                            TicketPublisherID = (int)Reader["TicketPublisherID"];
                            if (Reader["LastResponse"] != DBNull.Value)
                            {
                                LastResponse = (string)Reader["LastResponse"];
                            }
                            else
                            {
                                LastResponse = "";
                            }
                            if (Reader["LastResponserID"] != DBNull.Value)
                            {
                                LastResponserID = (int)Reader["LastResponserID"];
                            }
                            else
                            {
                                LastResponserID = -1;
                            }
                            CreatedDate = (DateTime)Reader["CreatedDate"];
                            if (Reader["LastResponseDate"] != DBNull.Value)
                            {
                                LastResponseDate = (DateTime)Reader["LastResponseDate"];
                            }
                            else
                            {
                                LastResponseDate = DateTime.MaxValue;
                            }

                        }
                        Reader.Close();
                    }
                    catch (Exception ex)
                    {
                        // Log exception or handle accordingly
                        throw new ApplicationException("An error occurred while Find a record.", ex);
                    }
                }
            }
            return IsFound;
        }


        public static bool DoesSupportTicketsExists(int TicketID)
        {

            bool IsFound = false;

            string query = " SELECT Found = 1 FROM SupportTickets WHERE TicketID = @TicketID ";


            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.AddWithValue("@TicketID", TicketID);
                    try
                    {
                        Connection.Open();
                        object result = Command.ExecuteScalar();
                        if (result != null)
                        {
                            IsFound = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log exception or handle accordingly
                        throw new ApplicationException("An error occurred while Deleting a record.", ex);
                    }
                }
            }
            return IsFound;
        }


        public static DataTable GetAllSupportTickets()
        {

            DataTable dt = new DataTable();

            string query = " SELECT * FROM SupportTickets";


            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    try
                    {
                        Connection.Open();
                        SqlDataReader Reader = Command.ExecuteReader();
                        if (Reader.HasRows)
                        {
                            dt.Load(Reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log exception or handle accordingly
                        throw new ApplicationException("An error occurred while Deleting a record.", ex);
                    }
                }
            }
            return dt;
        }

        public static DataTable GetAllSupportTicketsForCustomer(int CustomerID)
        {

            DataTable dt = new DataTable();

            string query = " SELECT * FROM SupportTickets where TicketPublisherID = @CustomerID";


            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.AddWithValue("@CustomerID", CustomerID);
                    try
                    {
                        Connection.Open();
                        SqlDataReader Reader = Command.ExecuteReader();
                        if (Reader.HasRows)
                        {
                            dt.Load(Reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log exception or handle accordingly
                        throw new ApplicationException("An error occurred while Deleting a record.", ex);
                    }
                }
            }
            return dt;
        }
    }
}