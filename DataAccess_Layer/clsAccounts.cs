using System;
using Microsoft.Data.SqlClient;
using System.Data;
using Microsoft.Identity.Client;


namespace DataAccess_Layer
{

    public class clsAccounts
    {


        public static decimal GetTransactionsInPeriod(string AccountNumber, int Days, int TransactionTypeID)
        {
            decimal Amount = 0;

            string query = $" SELECT SUM(TransactionAmount) AS LastWeekTransactions  FROM Transactions JOIN Accounts ON Accounts.AccountID = Transactions.AccountID WHERE Accounts.AccountNumber = @AccountNumber AND TransactionTypeID = @TransactionTypeID AND TransactionDate BETWEEN DATEADD(DAY, -@Days, GETDATE()) AND GETDATE();";


            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
                    Command.Parameters.AddWithValue("@TransactionTypeID", TransactionTypeID);
                    Command.Parameters.AddWithValue("@Days", Days);
                    try
                    {
                        Connection.Open();
                        object result = Command.ExecuteScalar();

                        if (result != null && result != System.DBNull.Value)
                        {
                            Amount = (decimal)result;

                        }

                    }
                    catch (Exception ex)
                    {
                        // Log exception or handle accordingly
                        Amount = -1;
                    }

                }
            }
            return Amount;

        }

        public static int AddNewAccounts(int CustomerID, int AccountTypeID, decimal Balance, string AccountNumber, int CurrencyID, int Status, DateTime CreatedDate)
        {
            int AccountID = -1;
            string query = $"INSERT INTO Accounts (CustomerID, AccountTypeID, Balance, AccountNumber, CurrencyID, Status, CreatedDate)VALUES (@CustomerID, @AccountTypeID, @Balance, @AccountNumber, @CurrencyID, @Status, @CreatedDate); SELECT SCOPE_IDENTITY();";

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {


                    Command.Parameters.AddWithValue("@CustomerID", CustomerID);

                    Command.Parameters.AddWithValue("@AccountTypeID", AccountTypeID);

                    Command.Parameters.AddWithValue("@Balance", Balance );

                    Command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

                    Command.Parameters.AddWithValue("@CurrencyID", CurrencyID);

                    Command.Parameters.AddWithValue("@Status", Status);

                    Command.Parameters.AddWithValue("@CreatedDate", CreatedDate);



                    try
                    {
                        Connection.Open();
                        object result = Command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                        {
                            AccountID = InsertedID;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log exception or handle accordingly
                        throw new ApplicationException("An error occurred while adding a new record.", ex);
                    }
                }
            }

            return AccountID;
        }
        public static bool UpdateAccounts(int AccountID, int CustomerID, int AccountTypeID, decimal Balance, string AccountNumber, int CurrencyID, int Status, DateTime CreatedDate)
        {
            int RowsAffected = -1;
            string query = "UPDATE Accounts SET CustomerID = @CustomerID, AccountTypeID = @AccountTypeID, Balance = @Balance, AccountNumber = @AccountNumber, CurrencyID = @CurrencyID, Status = @Status, CreatedDate = @CreatedDate WHERE AccountID = @AccountID;";
            ;

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.AddWithValue("@AccountID", AccountID);

                    Command.Parameters.AddWithValue("@CustomerID", CustomerID);

                    Command.Parameters.AddWithValue("@AccountTypeID", AccountTypeID);

                    Command.Parameters.AddWithValue("@Balance", Balance);

                    Command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

                    Command.Parameters.AddWithValue("@CurrencyID", CurrencyID);

                    Command.Parameters.AddWithValue("@Status", Status);

                    Command.Parameters.AddWithValue("@CreatedDate", CreatedDate);



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


        public static bool DeleteAccounts(int AccountID)
        {

            int RowsAffected = -1;

            string query = "UPDATE ACCOUNTS set Accounts.Status = 3 Where Accounts.AccountID = @AccountID";


            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.AddWithValue("@AccountID", AccountID);
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


        public static bool FindByAccountNumber(ref int AccountID, ref int CustomerID, ref int AccountTypeID, ref decimal Balance, string AccountNumber, ref int CurrencyID, ref int Status, ref DateTime CreatedDate)
        {
            bool IsFound = false;
            string query = "select * from Accounts where AccountNumber = @AccountNumber ";

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
                    try
                    {
                        Connection.Open();
                        SqlDataReader Reader = Command.ExecuteReader();
                        if (Reader.Read())
                        {

                            IsFound = true;
                            CustomerID = (int)Reader["CustomerID"];
                            AccountTypeID = (int)Reader["AccountTypeID"];
                            Balance = (decimal)Reader["Balance"];
                            AccountID = (int)Reader["AccountID"];
                            CurrencyID = (int)Reader["CurrencyID"];
                            Status = (int)Reader["Status"];
                            CreatedDate = (DateTime)Reader["CreatedDate"];

                            Console.WriteLine("_-----------------------------" + CurrencyID);
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



        public static bool Find(int AccountID, ref int CustomerID, ref int AccountTypeID, ref decimal Balance, ref string AccountNumber, ref int CurrencyID, ref int Status, ref DateTime CreatedDate)
        {
            bool IsFound = false;
            string query = "select * from Accounts where AccountID = @AccountID";

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.AddWithValue("@AccountID", AccountID);
                    try
                    {
                        Connection.Open();
                        SqlDataReader Reader = Command.ExecuteReader();
                        if (Reader.Read())
                        {

                            IsFound = true;
                            CustomerID = (int)Reader["CustomerID"];
                            AccountTypeID = (int)Reader["AccountTypeID"];
                            Balance = (decimal)Reader["Balance"];
                            AccountNumber = (string)Reader["AccountNumber"];
                            CurrencyID = (int)Reader["CurrencyID"];
                            Status = (int)Reader["Status"];
                            CreatedDate = (DateTime)Reader["CreatedDate"];

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


        public static bool FindByApplicationID(int ApplicationID, ref int AccountID, ref int CustomerID, ref int AccountTypeID, ref decimal Balance, ref string AccountNumber, ref int CurrencyID, ref int Status, ref DateTime CreatedDate)
        {
            bool IsFound = false;
            string query = "select Accounts.* from Applications join Accounts ON Applications.AccountID = Accounts.AccountID where ApplicationID = @ApplicationID";

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                    try
                    {
                        Connection.Open();
                        SqlDataReader Reader = Command.ExecuteReader();
                        if (Reader.Read())
                        {

                            IsFound = true;
                            AccountID = (int)Reader["AccountID"];
                            CustomerID = (int)Reader["CustomerID"];
                            AccountTypeID = (int)Reader["AccountTypeID"];
                            Balance = (decimal)Reader["Balance"];
                            AccountNumber = (string)Reader["AccountNumber"];
                            CurrencyID = (int)Reader["CurrencyID"];
                            Status = (int)Reader["Status"];
                            CreatedDate = (DateTime)Reader["CreatedDate"];

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


        public static bool DoesAccountsExists(int AccountID)
        {

            bool IsFound = false;

            string query = " SELECT Found = 1 FROM Accounts WHERE AccountID = @AccountID ";


            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.AddWithValue("@AccountID", AccountID);
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


        public static bool IsValidAccountNumber(string AccountNumber)
        {

            bool IsValid = false;

            string query = " SELECT Count(1) FROM Accounts WHERE AccountNumber = @AccountNumber ";


            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
                    try
                    {
                        Connection.Open();
                        int count = (int)Command.ExecuteScalar();
                        IsValid = count == 0;
                    }
                    catch (Exception ex)
                    {
                        // Log exception or handle accordingly
                        IsValid = false;
                    }

                }
            }
            return IsValid;
        }




        public static DataTable GetCustomersActiveAccounts(int CustomerID)
        {

            DataTable dt = new DataTable();

            string query = " select AccountNumber, Balance ,AccountTypes.AccountType , Currencies.CurrencyName, Currencies.CurrencySymbol, CreatedDate, Dollar = Balance* Currencies.ExchangeRateTOUSD from Accounts join AccountTypes ON Accounts.AccountTypeID = AccountTypes.AccountTypeID join Currencies ON Currencies.CurrencyID = Accounts.CurrencyID Where Status = 1 and CustomerID = @CustomerID";


            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {

                    try
                    {
                        Command.Parameters.AddWithValue("@CustomerID", CustomerID);
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


        public static DataTable GetAllAccountsForCustomer(int CustomerID)
        {

            DataTable dt = new DataTable();

            string query = " select AccountID, CustomerID, AccountNumber, AccountTypes.AccountType, Balance, Currencies.CurrencyName , CreatedDate, CASE  WHEN Accounts.Status = 1 THEN 'Active' WHEN Accounts.Status = 2 THEN 'Frozen' WHEN Accounts.Status = 3 THEN 'Closed' WHEN Accounts.Status = 4 THEN 'Pending' WHEN Accounts.Status = 5 THEN 'Rejected' End as Status from accounts join AccountTypes ON accounts.AccountTypeID = AccountTypes.AccountTypeID join Currencies ON Currencies.CurrencyID = Accounts.CurrencyID where Accounts.CustomerID = @CustomerID";


            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {

                    try
                    {
                        Command.Parameters.AddWithValue("@CustomerID", CustomerID);
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

        public static bool DoesCustomerHaveActiveAccount(int CustomerID)
        {

            bool IsFound = false;

            string query = "SELECT Top 1 R=1  FROM Accounts WHERE Accounts.CustomerID = @CustomerID and Accounts.Status = 1";


            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.AddWithValue("@CustomerID", CustomerID);
                    try
                    {
                        Connection.Open();
                        object result = Command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
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


        public static bool DoesCustomerHaveAccountsOnPending(int CustomerID)
        {

            bool IsFound = false;

            string query = "SELECT Top 1 R=1  FROM Accounts WHERE Accounts.CustomerID = @CustomerID and Accounts.Status = 4";


            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.AddWithValue("@CustomerID", CustomerID);
                    try
                    {
                        Connection.Open();
                        object result = Command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
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


        public static DataTable GetAllAccounts()
        {

            DataTable dt = new DataTable();

            string query = " select AccountID, CustomerID, AccountNumber, AccountTypes.AccountType, Balance, Currencies.CurrencyName , CreatedDate, CASE  WHEN Accounts.Status = 1 THEN 'Active' WHEN Accounts.Status = 2 THEN 'Frozen' WHEN Accounts.Status = 3 THEN 'Closed' WHEN Accounts.Status = 4 THEN 'Pending' WHEN Accounts.Status = 5 THEN 'Rejected' End as Status from accounts join AccountTypes ON accounts.AccountTypeID = AccountTypes.AccountTypeID join Currencies ON Currencies.CurrencyID = Accounts.CurrencyID";


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