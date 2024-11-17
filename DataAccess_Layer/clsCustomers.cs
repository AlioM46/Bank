using System;
using Microsoft.Data.SqlClient;
using System.Data;


namespace DataAccess_Layer
{

    public class clsCustomers
    {


        public static int YourBalanceRank(int CustomerID)
        {
            int Rank = -1;
            string query = @"WITH RankedCustomers AS (
                         SELECT 
                             Customers.CustomerID,
                             Customers.CustomerName,
                             SUM(Accounts.Balance * Currencies.ExchangeRateToUSD) AS TotalBalance,
                             ROW_NUMBER() OVER (ORDER BY SUM(Accounts.Balance * Currencies.ExchangeRateToUSD) DESC) AS Rank
                         FROM 
                             Accounts
                         JOIN 
                             Currencies ON Currencies.CurrencyID = Accounts.CurrencyID
                         JOIN 
                             Customers ON Customers.CustomerID = Accounts.CustomerID
                         WHERE 
                             Accounts.Status = 1
                         GROUP BY 
                             Customers.CustomerID, Customers.CustomerName
                     ) 
                     SELECT Rank 
                     FROM RankedCustomers 
                     WHERE CustomerID = @CustomerID;";

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
                            Rank = Convert.ToInt32(result); // Convert to Int32 safely
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log or handle the exception as necessary
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            return Rank;
        }

        public static double GetAllAccountsBalanceInDollar(int CustomerID)
        {
            double balance = 0;
            string query = $"Select CAST(SUM(Balance * Currencies.ExchangeRateToUSD) as float) as TOTAL From Accounts Join Currencies on Currencies.CurrencyID = Accounts.CurrencyID where Accounts.CustomerID = @CustomerID And Status = 1 ";

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
                            balance = (double)result;
                        }
                    }
                    catch (Exception ex)
                    {
                        balance = -1;
                    }
                }
            }
            return balance;
        }

        public static bool IsCustomerNameAvailable(string CustomerName)
        {
            bool IsValid = false;
            string query = $"select COUNT(1)  from Customers Where CustomerName = @CustomerName";

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {



                    Command.Parameters.AddWithValue("@CustomerName", CustomerName);



                    try
                    {
                        Connection.Open();
                        int count = (int)Command.ExecuteScalar();
                        IsValid = count == 0;
                    }
                    catch (Exception ex)
                    {
                        IsValid = false;
                    }
                }
            }
            return IsValid;
        }
        public static bool IsThePersonAvailableToConnectWithCustomer(int PersonID)
        {

            bool IsValid = false;
            string query = $"select COUNT(1)  from Customers Where Customers.PersonID = @PersonID";

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {



                    Command.Parameters.AddWithValue("@PersonID", PersonID);



                    try
                    {
                        Connection.Open();
                        int count = (int)Command.ExecuteScalar();
                        IsValid = count == 0;
                    }
                    catch (Exception ex)
                    {
                        IsValid = false;
                    }
                }
            }
            return IsValid;
        }

        public static bool IsValidCredentials(string name, string hashedPassword)
        {
            bool IsValid = false;
            string query = $"select COUNT(1)  from Customers Where Password = @Password and CustomerName = @Name";

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {



                    Command.Parameters.AddWithValue("@Name", name);

                    Command.Parameters.AddWithValue("@Password", hashedPassword);


                    try
                    {
                        Connection.Open();
                        int count = (int)Command.ExecuteScalar();
                        IsValid = count > 0;
                    }
                    catch (Exception ex)
                    {
                        IsValid = false;
                    }
                }
            }
            return IsValid;


        }

        public static int AddNewCustomers(int PersonID, string CustomerName, string Password, bool IsActive, DateTime CreatedDate)
        {
            int CustomerID = -1;
            string query = $"INSERT INTO Customers (PersonID, CustomerName, Password, IsActive, CreatedDate)VALUES (@PersonID, @CustomerName, @Password, @IsActive, @CreatedDate); SELECT SCOPE_IDENTITY();";

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {


                    Command.Parameters.AddWithValue("@PersonID", PersonID);

                    Command.Parameters.AddWithValue("@CustomerName", CustomerName);

                    Command.Parameters.AddWithValue("@Password", Password);

                    Command.Parameters.AddWithValue("@IsActive", IsActive);

                    Command.Parameters.AddWithValue("@CreatedDate", CreatedDate);



                    try
                    {
                        Connection.Open();
                        object result = Command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                        {
                            CustomerID = InsertedID;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log exception or handle accordingly
                        throw new ApplicationException("An error occurred while adding a new record.", ex);
                    }
                }
            }

            return CustomerID;
        }
        public static bool UpdateCustomers(int CustomerID, int PersonID, string CustomerName, string Password, bool IsActive, DateTime CreatedDate)
        {
            int RowsAffected = -1;
            string query = "UPDATE Customers SET PersonID = @PersonID, CustomerName = @CustomerName, Password = @Password, IsActive = @IsActive, CreatedDate = @CreatedDate WHERE CustomerID = @CustomerID;";
            ;

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.AddWithValue("@CustomerID", CustomerID);


                    Command.Parameters.AddWithValue("@PersonID", PersonID);

                    Command.Parameters.AddWithValue("@CustomerName", CustomerName);

                    Command.Parameters.AddWithValue("@Password", Password);

                    Command.Parameters.AddWithValue("@IsActive", IsActive);

                    Command.Parameters.AddWithValue("@CreatedDate", CreatedDate);



                    try
                    {
                        Connection.Open();
                        RowsAffected = Command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Log exception or handle accordingly
                        RowsAffected = 0;
                    }
                }
            }
            return (RowsAffected > 0);
        }


        public static bool DeleteCustomers(int CustomerID)
        {

            int RowsAffected = -1;

            string query = " DELETE FROM Customers WHERE CustomerID = @CustomerID";


            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.AddWithValue("@CustomerID", CustomerID);
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


        public static bool Find(int CustomerID, ref int PersonID, ref string CustomerName, ref string Password, ref bool IsActive, ref DateTime CreatedDate)
        {
            bool IsFound = false;
            string query = "select * from Customers where CustomerID = @CustomerID";

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.AddWithValue("@CustomerID", CustomerID);
                    try
                    {
                        Connection.Open();
                        SqlDataReader Reader = Command.ExecuteReader();
                        if (Reader.Read())
                        {

                            IsFound = true;
                            PersonID = (int)Reader["PersonID"];
                            CustomerName = (string)Reader["CustomerName"];
                            Password = (string)Reader["Password"];
                            IsActive = (bool)Reader["IsActive"];
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

        public static bool Find(ref int CustomerID, ref int PersonID, string CustomerName, string Password, ref bool IsActive, ref DateTime CreatedDate)
        {
            bool IsFound = false;
            string query = "select * from Customers Where CustomerName = @Name and Password = @Password";

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.AddWithValue("@Name", CustomerName);
                    Command.Parameters.AddWithValue("@Password", Password);
                    try
                    {
                        Connection.Open();
                        SqlDataReader Reader = Command.ExecuteReader();
                        if (Reader.Read())
                        {

                            IsFound = true;
                            CustomerID = (int)Reader["CustomerID"];
                            PersonID = (int)Reader["PersonID"];
                            IsActive = (bool)Reader["IsActive"];
                            CreatedDate = (DateTime)Reader["CreatedDate"];

                        }
                        Reader.Close();
                    }
                    catch (Exception ex)
                    {
                        // Log exception or handle accordingly
                        IsFound = false;
                    }
                }
            }
            return IsFound;
        }

        public static bool DoesCustomersExists(int CustomerID)
        {

            bool IsFound = false;

            string query = " SELECT Found = 1 FROM Customers WHERE CustomerID = @CustomerID ";


            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.AddWithValue("@CustomerID", CustomerID);
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
        public static bool DoesCustomersExists(string name, string password)
        {

            bool IsFound = false;

            string query = " SELECT Found = 1 FROM Customers WHERE CustomerName = @Name and Password = @Password";


            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.AddWithValue("@Name", name);
                    Command.Parameters.AddWithValue("@Password", password);
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
                        IsFound = false;
                    }
                }
            }
            return IsFound;
        }



        public static DataTable GetTop5CustomerBalance()
        {

            DataTable dt = new DataTable();

            string query = " select top 5 Customers.CustomerName, Money = SUM(Accounts.Balance * Currencies.ExchangeRateTOUSD) from Customers join Accounts ON Customers.CustomerID = Accounts.CustomerID Join Currencies ON Currencies.CurrencyID = Accounts.CurrencyID where Accounts.Status = 1  group by CustomerName order by Money desc ";



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


        public static DataTable GetAllCustomers()
        {

            DataTable dt = new DataTable();

            string query = " select CustomerID, PersonID, CustomerName, IsActive, CreatedDate from Customers ";


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