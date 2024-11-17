using System;
using Microsoft.Data.SqlClient;
using System.Data;


namespace DataAccess_Layer{

public class clsTransactionTypes { 



	public static int AddNewTransactionTypes(string TransactionType, string TransactionDescription) {
		int TransactionTypeID = -1;
		string query = $"INSERT INTO TransactionTypes (TransactionType, TransactionDescription)VALUES (@TransactionType, @TransactionDescription); SELECT SCOPE_IDENTITY();";

		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{


		Command.Parameters.AddWithValue("@TransactionType", TransactionType);

		Command.Parameters.AddWithValue("@TransactionDescription", TransactionDescription);



				try
				{
					Connection.Open();
					object result = Command.ExecuteScalar();
						if (result != null && int.TryParse(result.ToString(), out int InsertedID))
						{
							TransactionTypeID = InsertedID;
						}
					}
					catch (Exception ex)
					{
						// Log exception or handle accordingly
						throw new ApplicationException("An error occurred while adding a new record.", ex);
					}
				}
			}

			return TransactionTypeID;
		}
public static bool UpdateTransactionTypes(int TransactionTypeID, string TransactionType, string TransactionDescription) {
		int RowsAffected = -1;
		string query = "UPDATE TransactionTypes SET TransactionType = @TransactionType, SET TransactionDescription = @TransactionDescription WHERE TransactionTypeID = @TransactionTypeID;"
;

		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{


		Command.Parameters.AddWithValue("@TransactionType", TransactionType);

		Command.Parameters.AddWithValue("@TransactionDescription", TransactionDescription);



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


	public static bool DeleteTransactionTypes(int TransactionTypeID) {

		int RowsAffected = -1;

		string query = " DELETE FROM TransactionTypes WHERE TransactionTypeID = @TransactionTypeID";


		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{
			Command.Parameters.AddWithValue("@TransactionTypeID", TransactionTypeID);
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


		public static bool Find(int TransactionTypeID,  ref string TransactionType,  ref string TransactionDescription) {
		bool IsFound= false;
		string query = "select * from TransactionTypes where TransactionTypeID = @TransactionTypeID";

		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{
			 Command.Parameters.AddWithValue("@TransactionTypeID", TransactionTypeID);
				try
				{
					Connection.Open();
					SqlDataReader Reader = Command.ExecuteReader();
					if (Reader.Read()) {

					IsFound = true;
								TransactionType = (string)Reader["TransactionType"];
			TransactionDescription = (string)Reader["TransactionDescription"];

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


	public static bool DoesTransactionTypesExists(int TransactionTypeID) {

		bool IsFound = false;

		string query = " SELECT Found = 1 FROM TransactionTypes WHERE TransactionTypeID = @TransactionTypeID ";


		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{
			Command.Parameters.AddWithValue("@TransactionTypeID", TransactionTypeID);
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


	public static DataTable GetAllTransactionTypes() {

		DataTable dt = new DataTable();

		string query = " SELECT * FROM TransactionTypes";


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