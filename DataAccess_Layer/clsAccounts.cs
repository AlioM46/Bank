using System;
using Microsoft.Data.SqlClient;
using System.Data;


namespace DataAccess_Layer{

public class clsAccounts { 



	public static int AddNewAccounts(int CustomerID, int AccountTypeID, decimal Balance, string AccountNumber, string Currency, int Status, DateTime CreatedDate) {
		int AccountID = -1;
		string query = $"INSERT INTO Accounts (CustomerID, AccountTypeID, Balance, AccountNumber, Currency, Status, CreatedDate)VALUES (@CustomerID, @AccountTypeID, @Balance, @AccountNumber, @Currency, @Status, @CreatedDate); SELECT SCOPE_IDENTITY();";

		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{


		Command.Parameters.AddWithValue("@CustomerID", CustomerID);

		Command.Parameters.AddWithValue("@AccountTypeID", AccountTypeID);

		Command.Parameters.AddWithValue("@Balance", Balance);

		Command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

		Command.Parameters.AddWithValue("@Currency", Currency);

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
public static bool UpdateAccounts(int AccountID, int CustomerID, int AccountTypeID, decimal Balance, string AccountNumber, string Currency, int Status, DateTime CreatedDate) {
		int RowsAffected = -1;
		string query = "UPDATE Accounts SET CustomerID = @CustomerID, SET AccountTypeID = @AccountTypeID, SET Balance = @Balance, SET AccountNumber = @AccountNumber, SET Currency = @Currency, SET Status = @Status, SET CreatedDate = @CreatedDate WHERE AccountID = @AccountID;"
;

		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{


		Command.Parameters.AddWithValue("@CustomerID", CustomerID);

		Command.Parameters.AddWithValue("@AccountTypeID", AccountTypeID);

		Command.Parameters.AddWithValue("@Balance", Balance);

		Command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

		Command.Parameters.AddWithValue("@Currency", Currency);

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


	public static bool DeleteAccounts(int AccountID) {

		int RowsAffected = -1;

		string query = " DELETE FROM Accounts WHERE AccountID = @AccountID";


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


		public static bool Find(int AccountID,  ref int CustomerID,  ref int AccountTypeID,  ref decimal Balance,  ref string AccountNumber,  ref string Currency,  ref int Status,  ref DateTime CreatedDate) {
		bool IsFound= false;
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
					if (Reader.Read()) {

					IsFound = true;
								CustomerID = (int)Reader["CustomerID"];
			AccountTypeID = (int)Reader["AccountTypeID"];
			Balance = (decimal)Reader["Balance"];
			AccountNumber = (string)Reader["AccountNumber"];
			Currency = (string)Reader["Currency"];
			Status = (int)Reader["Status"];
			CreatedDate = (DateTime)Reader["CreatedDate"];

					}
				Reader.Close();					}
					catch (Exception ex)
					{
						// Log exception or handle accordingly
						throw new ApplicationException("An error occurred while Find a record.", ex);
					}
				}
			}
		 return IsFound;
	}


	public static bool DoesAccountsExists(int AccountID) {

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
					if (result != null) {
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


	public static DataTable GetAllAccounts(int AccountID) {

		DataTable dt = new DataTable();

		string query = " SELECT * FROM Accounts";


		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{
				try
				{
					Connection.Open();
					SqlDataReader Reader = Command.ExecuteReader();
					if (Reader.HasRows) {
					dt.Load(Reader);					}
				}
					catch (Exception ex)
					{
						// Log exception or handle accordingly
						throw new ApplicationException("An error occurred while Deleting a record.", ex);
					}
				}
			}
		 return dt;
	}		}
	}