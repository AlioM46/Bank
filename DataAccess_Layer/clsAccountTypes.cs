using System;
using Microsoft.Data.SqlClient;
using System.Data;


namespace DataAccess_Layer
{

    public class clsAccountTypes
    {


        public static int AddNewAccountTypes(string AccountType, decimal Fees, string Description, decimal DailyDepositLimit, decimal DailyWithdrawLimit)
        {
            int AccountTypeID = -1;
            string query = $"INSERT INTO AccountTypes (AccountType, Fees, Description, DepositDailyLimit, WithdrawDailyLimit)VALUES (@AccountType, @Fees, @Description, @DailyDepositLimit, @DailyWithdrawLimit); SELECT SCOPE_IDENTITY();";

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {


                    Command.Parameters.AddWithValue("@AccountType", AccountType);

                    Command.Parameters.AddWithValue("@Fees", Fees);


                    Command.Parameters.AddWithValue("@DailyWithdrawLimit", DailyWithdrawLimit);

                    Command.Parameters.AddWithValue("@DailyDepositLimit", DailyDepositLimit);


                    if (Description != "" && Description != null)
                    {

                        Command.Parameters.AddWithValue("@Description", Description);
                    }
                    else
                    {

                        Command.Parameters.AddWithValue("@Description", DBNull.Value);
                    }



                    try
                    {
                        Connection.Open();
                        object result = Command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                        {
                            AccountTypeID = InsertedID;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log exception or handle accordingly
                        throw new ApplicationException("An error occurred while adding a new record.", ex);
                    }
                }
            }

            return AccountTypeID;
        }
        public static bool UpdateAccountTypes(int AccountTypeID, string AccountType, decimal Fees, string Description, decimal DepositDailyLimit, decimal WithdrawDailyLimit)
        {
            int RowsAffected = -1;
            string query = @"
        UPDATE AccountTypes 
        SET 
            AccountType = @AccountType, 
            Fees = @Fees, 
            Description = @Description, 
            DepositDailyLimit = @DepositDailyLimit, 
            WithdrawDailyLimit = @WithdrawDailyLimit 
        WHERE AccountTypeID = @AccountTypeID;";



            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {


                    Command.Parameters.AddWithValue("@AccountType", AccountType);
                    Command.Parameters.AddWithValue("@AccountTypeID", AccountTypeID);

                    Command.Parameters.AddWithValue("@Fees", Fees);

                    Command.Parameters.AddWithValue("@DepositDailyLimit", DepositDailyLimit);
                    Command.Parameters.AddWithValue("@WithdrawDailyLimit", WithdrawDailyLimit);


                    if (Description != "" && Description != null)
                    {

                        Command.Parameters.AddWithValue("@Description", Description);
                    }
                    else
                    {

                        Command.Parameters.AddWithValue("@Description", DBNull.Value);
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


        public static bool DeleteAccountTypes(int AccountTypeID)
        {

            int RowsAffected = -1;

            string query = " DELETE FROM AccountTypes WHERE AccountTypeID = @AccountTypeID";


            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.AddWithValue("@AccountTypeID", AccountTypeID);
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


        public static bool Find(int AccountTypeID, ref string AccountType, ref decimal Fees, ref string Description, ref decimal DailyWithdrawLimit, ref decimal DailyDepositLimit)
        {
            bool IsFound = false;
            string query = "select * from AccountTypes where AccountTypeID = @AccountTypeID";

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.AddWithValue("@AccountTypeID", AccountTypeID);
                    try
                    {
                        Connection.Open();
                        SqlDataReader Reader = Command.ExecuteReader();
                        if (Reader.Read())
                        {

                            IsFound = true;

                            DailyDepositLimit = (decimal)Reader["DepositDailyLimit"];
                            DailyWithdrawLimit = (decimal)Reader["WithdrawDailyLimit"];

                            AccountType = (string)Reader["AccountType"];
                            Fees = (decimal)Reader["Fees"];
                            if (Reader["Description"] != DBNull.Value)
                            {
                                Description = (string)Reader["Description"];
                            }
                            else
                            {
                                Description = "";
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


        public static bool DoesAccountTypesExists(int AccountTypeID)
        {

            bool IsFound = false;

            string query = " SELECT Found = 1 FROM AccountTypes WHERE AccountTypeID = @AccountTypeID ";


            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.AddWithValue("@AccountTypeID", AccountTypeID);
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

        public static DataTable GetAllCurrencies()
        {

            DataTable dt = new DataTable();

            string query = " SELECT * FROM Currencies";


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

        public static DataTable GetAllAccountTypes()
        {

            DataTable dt = new DataTable();

            string query = " SELECT * FROM AccountTypes";


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