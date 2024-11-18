using System;
using Microsoft.Data.SqlClient;
using System.Data;


namespace DataAccess_Layer
{

    public class clsTransactions
    {



        public static int AddNewTransactions(int AccountID, int TransactionTypeID, DateTime TransactionDate, decimal TransactionAmount, int CustomerID)
        {
            int TransactionID = -1;
            string query = $"INSERT INTO Transactions (AccountID, TransactionTypeID, TransactionDate, TransactionAmount, CustomerID)VALUES (@AccountID, @TransactionTypeID, @TransactionDate, @TransactionAmount, @CustomerID); SELECT SCOPE_IDENTITY();";

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {


                    if (AccountID != -1 && AccountID != null)
                    {

                        Command.Parameters.AddWithValue("@AccountID", AccountID);
                    }
                    else
                    {

                        Command.Parameters.AddWithValue("@AccountID", DBNull.Value);
                    }

                    if (TransactionTypeID != -1 && TransactionTypeID != null)
                    {

                        Command.Parameters.AddWithValue("@TransactionTypeID", TransactionTypeID);
                    }
                    else
                    {

                        Command.Parameters.AddWithValue("@TransactionTypeID", DBNull.Value);
                    }

                    if (TransactionDate != DateTime.MaxValue && TransactionDate != null)
                    {

                        Command.Parameters.AddWithValue("@TransactionDate", TransactionDate);
                    }
                    else
                    {

                        Command.Parameters.AddWithValue("@TransactionDate", DBNull.Value);
                    }

                    if (TransactionAmount != -1 && TransactionAmount != null)
                    {

                        Command.Parameters.AddWithValue("@TransactionAmount", TransactionAmount);
                    }
                    else
                    {

                        Command.Parameters.AddWithValue("@TransactionAmount", DBNull.Value);
                    }

                    if (CustomerID != -1 && CustomerID != null)
                    {

                        Command.Parameters.AddWithValue("@CustomerID", CustomerID);
                    }
                    else
                    {

                        Command.Parameters.AddWithValue("@CustomerID", DBNull.Value);
                    }



                    try
                    {
                        Connection.Open();
                        object result = Command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                        {
                            TransactionID = InsertedID;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log exception or handle accordingly
                        throw new ApplicationException("An error occurred while adding a new record.", ex);
                    }
                }
            }

            return TransactionID;
        }
        public static bool UpdateTransactions(int TransactionID, int AccountID, int TransactionTypeID, DateTime TransactionDate, decimal TransactionAmount, int CustomerID)
        {
            int RowsAffected = -1;
            string query = "UPDATE Transactions SET AccountID = @AccountID, SET TransactionTypeID = @TransactionTypeID, SET TransactionDate = @TransactionDate, SET TransactionAmount = @TransactionAmount, SET CustomerID = @CustomerID WHERE TransactionID = @TransactionID;"
    ;

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {


                    if (AccountID != -1 && AccountID != null)
                    {

                        Command.Parameters.AddWithValue("@AccountID", AccountID);
                    }
                    else
                    {

                        Command.Parameters.AddWithValue("@AccountID", DBNull.Value);
                    }

                    if (TransactionTypeID != -1 && TransactionTypeID != null)
                    {

                        Command.Parameters.AddWithValue("@TransactionTypeID", TransactionTypeID);
                    }
                    else
                    {

                        Command.Parameters.AddWithValue("@TransactionTypeID", DBNull.Value);
                    }

                    if (TransactionDate != DateTime.MaxValue && TransactionDate != null)
                    {

                        Command.Parameters.AddWithValue("@TransactionDate", TransactionDate);
                    }
                    else
                    {

                        Command.Parameters.AddWithValue("@TransactionDate", DBNull.Value);
                    }

                    if (TransactionAmount != -1 && TransactionAmount != null)
                    {

                        Command.Parameters.AddWithValue("@TransactionAmount", TransactionAmount);
                    }
                    else
                    {

                        Command.Parameters.AddWithValue("@TransactionAmount", DBNull.Value);
                    }

                    if (CustomerID != -1 && CustomerID != null)
                    {

                        Command.Parameters.AddWithValue("@CustomerID", CustomerID);
                    }
                    else
                    {

                        Command.Parameters.AddWithValue("@CustomerID", DBNull.Value);
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


        public static bool DeleteTransactions(int TransactionID)
        {

            int RowsAffected = -1;

            string query = " DELETE FROM Transactions WHERE TransactionID = @TransactionID";


            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.AddWithValue("@TransactionID", TransactionID);
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


        public static bool Find(int TransactionID, ref int AccountID, ref int TransactionTypeID, ref DateTime TransactionDate, ref decimal TransactionAmount, ref int CustomerID)
        {
            bool IsFound = false;
            string query = "select * from Transactions where TransactionID = @TransactionID";

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.AddWithValue("@TransactionID", TransactionID);
                    try
                    {
                        Connection.Open();
                        SqlDataReader Reader = Command.ExecuteReader();
                        if (Reader.Read())
                        {

                            IsFound = true;
                            if (Reader["AccountID"] != DBNull.Value)
                            {
                                AccountID = (int)Reader["AccountID"];
                            }
                            else
                            {
                                AccountID = -1;
                            }
                            if (Reader["TransactionTypeID"] != DBNull.Value)
                            {
                                TransactionTypeID = (int)Reader["TransactionTypeID"];
                            }
                            else
                            {
                                TransactionTypeID = -1;
                            }
                            if (Reader["TransactionDate"] != DBNull.Value)
                            {
                                TransactionDate = (DateTime)Reader["TransactionDate"];
                            }
                            else
                            {
                                TransactionDate = DateTime.MaxValue;
                            }
                            if (Reader["TransactionAmount"] != DBNull.Value)
                            {
                                TransactionAmount = (decimal)Reader["TransactionAmount"];
                            }
                            else
                            {
                                TransactionAmount = -1;
                            }
                            if (Reader["CustomerID"] != DBNull.Value)
                            {
                                CustomerID = (int)Reader["CustomerID"];
                            }
                            else
                            {
                                CustomerID = -1;
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


        public static bool DoesTransactionsExists(int TransactionID)
        {

            bool IsFound = false;

            string query = " SELECT Found = 1 FROM Transactions WHERE TransactionID = @TransactionID ";


            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.AddWithValue("@TransactionID", TransactionID);
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


        public static DataTable GetAllTransactionsRecordsInPeriod(int Days, int CustomerID)
        {

            DataTable dt = new DataTable();

            string query = " select TransactionID , AccountNumber, TransactionTypes.TransactionType, TransactionDate,TransactionAmount  from Transactions join TransactionTypes on Transactions.TransactionTypeID = TransactionTypes.TransactionTypeID join Accounts on Accounts.AccountID = Transactions.AccountID where Transactions.CustomerID = @CustomerID AND TransactionDate BETWEEN DATEADD(DAY, -@Days, GETDATE()) AND GETDATE() order by AccountNumber";


            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.AddWithValue("@CustomerID", CustomerID);
                    Command.Parameters.AddWithValue("@Days", Days);
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

                    }
                }
            }
            return dt;
        }

        public static DataTable GetAllTransactions()
        {

            DataTable dt = new DataTable();

            string query = " SELECT * FROM Transactions";


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
    }
}